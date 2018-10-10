using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account("aknur","123456");
            Account account2 = new Account("aknur", "654321");

            Console.WriteLine(account1 == account2);
            Console.Read();
  

        }
    }
}
