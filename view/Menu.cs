using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstApp.entity;

namespace firstApp.view.menu
{
    public class Menu
    {
        
        public int updateIfAccountFoundMenu()
        {
            Console.WriteLine("1 - Name \n" +
                "2 - Email\n" +
                "3 - Password\n");
            return Int32.Parse(Console.ReadLine());
        }

        public int getAccountByIdMenu()
        {
            Console.WriteLine("Input ID ");
            return Int32.Parse(Console.ReadLine());
        }

        public void showAllAccounts(List<AccountTable> accountTables)
        {
            accountTables.ForEach(AccountTable => showAccount(AccountTable));
        }

        public void showAccount(AccountTable account) {
            Console.WriteLine($"\t{account.Id, -3} {account.Name, -15} {account.Email, -25} {account.Password}");
        }

        public string updateAccountName()
        {
            Console.WriteLine("\nInput Name\n");
            return Console.ReadLine();
        }
    }
}
