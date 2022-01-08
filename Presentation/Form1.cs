using DemoLibrary;
using System;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        private Customer customer = new Customer();
        public Form1()
        {
            InitializeComponent();
            overdraftLabel.Hide();
            InitializeCustomer();
            FillTheBoard();
        }

        private void FillTheBoard()
        {
            nameLabel.Text = customer.Name;
            checkingLabel.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
            savingsLabel.Text = string.Format("{0:C2}", customer.SavingAccount.Balance);
            savingListBox.DataSource = customer.SavingAccount.Transactions;
            checkingListBox.DataSource = customer.CheckingAccount.Transactions;
        }

        private void InitializeCustomer()
        {
            customer.Name = "Samvel Avagyan";
            customer.CheckingAccount = new Account();
            customer.SavingAccount = new Account();
            customer.CheckingAccount.Name = "Samvel's checking account";
            customer.SavingAccount.Name = "Samvel's saving account";
            customer.CheckingAccount.AddDeposit(151.57M, "Initial");
            customer.SavingAccount.AddDeposit(140.58M, "Initial");
            customer.CheckingAccount.TransactionApprovedEvent += CheckingAccountTransactionApprovedEvent;
            customer.CheckingAccount.OverdraftedEvent += CheckingAccountOverdraftedEvent;
            customer.SavingAccount.TransactionApprovedEvent += SavingAccountTransactionApprovedEvent;
        }

        private void CheckingAccountOverdraftedEvent(object sender, OverdraftEventArgs e)
        {
            overdraftLabel.Text = $"You have overdrafted {string.Format("{0:C2}", e.SumNeeded)}";
            e.CancelTransaction = denyOverdrafting.Checked;
            overdraftLabel.Show();
        }

        private void SavingAccountTransactionApprovedEvent(object sender, string e)
        {
            savingListBox.DataSource = null;
            savingListBox.DataSource = customer.SavingAccount.Transactions;
            savingsLabel.Text = string.Format("{0:C2}", customer.SavingAccount.Balance);
        }

        private void CheckingAccountTransactionApprovedEvent(object sender, string e)
        {
            checkingListBox.DataSource = null;
            checkingListBox.DataSource = customer.CheckingAccount.Transactions;
            checkingLabel.Text = string.Format("{0:C2}", customer.CheckingAccount.Balance);
        }

        private void OverdraftLabelClick(object sender, EventArgs e)
        {
            overdraftLabel.Hide();
        }

        private void AddTransactionButtonClick(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction(customer);
            transaction.Show();
        }
    }
}
