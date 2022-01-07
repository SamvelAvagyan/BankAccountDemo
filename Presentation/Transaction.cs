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
    public partial class Transaction : Form
    {
        private Customer _customer;
        public Transaction(Customer customer)
        {
            InitializeComponent();
            overdraftingLabel.Hide();
            _customer = customer;
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
