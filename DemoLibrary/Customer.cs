using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class Customer
    {
        public string Name { get; set; }

        public Account CheckingAccount { get; set; }
        public Account SavingAccount { get; set; }
    }
}
