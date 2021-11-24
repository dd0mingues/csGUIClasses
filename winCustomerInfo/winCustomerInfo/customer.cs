using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winCustomerInfo
{
    class Customer
    {
        private string fName;
        private string lName;
        private string phNbr;
        private string county;

        public string FName { get => fName; set => fName = value; }
        public string LName { get => lName; set => lName = value; }
        public string PhNbr { get => phNbr; set => phNbr = value; }
        public string County { get => county; set => county = value; }

        public Customer(string fName, string lName, string phNbr, string county)
        {
            this.fName = fName;
            this.lName = lName;
            this.phNbr = phNbr;
            this.county = county;

        }
    }
}
