using DemoLibrary;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Transaction : Form
    {
        private Customer _customer;
        public Transaction(Customer customer)
        {
            InitializeComponent();
            overdraftingLabel.Hide();
            _customer = customer;
            customer.CheckingAccount.OverdraftedEvent += CheckingAccountOverdraftedEvent;
        }

        private void CheckingAccountOverdraftedEvent(object sender, OverdraftEventArgs e)
        {
            overdraftingLabel.Show();
        }

        private void OverdraftingLabelClick(object sender, EventArgs e)
        {
            overdraftingLabel.Hide();
        }

        private void AddTransactionButtonClick(object sender, EventArgs e)
        {
            bool isSucceded = _customer.CheckingAccount.MakePayment(sumUpDown.Value, transactionName.Text, _customer.SavingAccount);
            sumUpDown.Value = 0;
        }
    }
}
