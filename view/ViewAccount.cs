using firstApp.controller.controllerAccount;
using firstApp.entity;
using firstApp.view.menu;

namespace firstApp.view.ViewAccount
{
    public class ViewAccount
    {
        static Menu menu = new Menu();
        static ControllereAccount controllereAccount = new ControllereAccount();
        public void initialInterface()
        {

        }

        static public void showAllAccounts()
        {
            menu.showAllAccounts(controllereAccount.getAllAccounts());
        }

        public void getAccountById()
        {

        }

        static public void createNewAccount()
        {
            string name = "db";
            string email = "newEmadbilness";
            string password = "newPautssword";
            controllereAccount.createNewAccount(name, email, password);

        }

        static public void updateAccount()
        {
            AccountTable foundedAccount = controllereAccount.getAccountById(menu.getAccountByIdMenu());
            menu.showAccount(foundedAccount);
            int exercise = menu.updateIfAccountFoundMenu();
            string update = "";
            if (exercise == 1) {update = menu.updateAccountName();}
            else if(exercise == 2) {}
            controllereAccount.updateAccountName(foundedAccount.Id, update);
        }
    }
}
