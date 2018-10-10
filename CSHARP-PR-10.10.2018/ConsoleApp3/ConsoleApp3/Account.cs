using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Account
    {
        
        public string Login { get; set; }
        public string Password { get; set; }

        public Account(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public static bool operator ==(Account account1, Account account2)
        {
            if (account1.Login == account2.Login)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(Account account1, Account account2)
            {
            if (account1.Login != account2.Login)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
