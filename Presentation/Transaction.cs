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
            overdraftingLabel1.Hide();
        }

        private void overdraftingLabel1_Click(object sender, EventArgs e)
        {
            overdraftingLabel1.Hide();
        }
    }
}
