using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstApp.view.ViewAccount;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewAccount.showAllAccounts();
            Console.WriteLine();
            ViewAccount.updateAccount();
            Console.WriteLine();
            ViewAccount.showAllAccounts();
            Console.ReadLine();

        }
    }
}
