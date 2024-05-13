using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstApp.entity;
using firstApp.controller.controllerAccount;

namespace firstApp.view.ViewAccount
{
    public class ViewAccount
    {
        static ControllereAccount controllereAccount = new ControllereAccount();
        public void initialInterface()
        {

        }

         static public  void showAllAccounts()
        {
            controllereAccount.getAllAccounts().ForEach(AccountTable => Console.WriteLine(AccountTable.Name + " " +
                AccountTable.Email + " " + AccountTable.Password));
        }

        public void getAccountById()
        {

        }

        static public void createNewAccount()
        {
            string name = "newName";
            string email = "newEmail";
            string password = "newPass";
            controllereAccount.createNewAccount(name, email, password);

        } 
    }
}
