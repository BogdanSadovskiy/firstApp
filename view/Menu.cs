using firstApp.entity;
using System;
using System.Collections.Generic;

namespace firstApp.view.menu
{
    public class Menu
    {
        public int showInitialInterface()
        {
            Console.WriteLine("  1 - Show all accounts");
            Console.WriteLine("  2 - Add account");
            Console.WriteLine("  3 - Update account");
            Console.WriteLine("  4 - Get account by ID");
            Console.WriteLine("  5 - Delete account");
            return Int32.Parse(Console.ReadLine());

        }

        public int deleteAccount()
        {
            Console.WriteLine("Delete this account?/n1 - YES / 0 - no");
            return Int32.Parse(Console.ReadLine());
        }

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

        public void showAllUsers(List<User> users)
        {
            if (users != null)
            {
                users.ForEach(user => showAccount(user));
            }
        }

        public void showAccount(User account)
        {
            Console.WriteLine($"\t{account.Id,-3} " +
                $"{account.FirstName,-10} " +
                $"{account.LastName, -15} " +
                $"{account.PhoneNumber, -15} " +
                $"{account.Email,-15} " +
                $"{account.Password, -25} " +
                $"{account.RoleId,-5}");
        }

        public string updateAccountName()
        {
            Console.WriteLine("\nInput Name\n");
            return Console.ReadLine();
        }
    }
}
