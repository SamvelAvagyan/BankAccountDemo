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
        public Transaction()
        {
            InitializeComponent();
            overdraftingLabel.Hide();
        }

        private void OverdraftingLabelClick(object sender, EventArgs e)
        {
            overdraftingLabel.Hide();
        }

        private void AddTransactionButtonClick(object sender, EventArgs e)
        {

        }
    }
}
