using System.Collections.Generic;

namespace DemoLibrary
{
    public class Account
    {
        private List<string> _transactions = new List<string>();
        public decimal Balance { get; private set; }
        public string Name { get; set; }
        public IReadOnlyList<string> Transactions
        {
            get { return this._transactions.AsReadOnly(); }
        }

        public bool AddDeposit(decimal sum, string depositName)
        {
            this._transactions.Add($"Deposited {string.Format("{0:C2}", sum)} for {depositName}");
            this.Balance += sum;
            return true;
        }

        public bool MakePayment(decimal sum, string paymentName, Account backupAccount = null)
        {
            if (sum <= this.Balance)
            {
                this._transactions.Add($"Withdrew {string.Format("{0:C2}", sum)} for {paymentName}");
                this.Balance -= sum;
                return true;
            }
            else
            {
                if (backupAccount == null)
                {
                    return false;
                }
                else
                {
                    if ((backupAccount.Balance + this.Balance) > sum)
                    {
                        bool overdraftSucceded = MakePayment(sum - this.Balance, "Overdraft");

                        if (!overdraftSucceded)
                        {
                            return false;
                        }

                        AddDeposit(sum - this.Balance, "Overdraft Deposit");
                        this._transactions.Add($"Withdrew {string.Format("{0:C2}", sum)} for {paymentName}");
                        this.Balance -= sum;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
