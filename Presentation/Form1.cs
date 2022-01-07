using DemoLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class Form1 : Form
    {
        Customer customer = new Customer();
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
        }

        private void OverdraftLabelClick(object sender, EventArgs e)
        {
            overdraftLabel.Hide();
        }

        private void AddTransactionButtonClick(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.Show();
        }
    }
}
