using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace winLogin
{
    class User
    {
        //private atrributes
        private string userName;
        private string password;
        private int tries;

        //default constructor
        public User() { }

        //overloaded constructor
        public User(string strUserName, string strPassword)
        {
            userName = strUserName;
            password = strPassword;
            tries = 3;
        }

        //encapsulation of the private attriutes
        public string UserName { get => userName; set => userName = value; }
        public string Password { get => password; set => password = value; }
        public int Tries { get => tries; set => tries = value; }

    }
}
