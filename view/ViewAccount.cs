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
            int chooseMenu = menu.showInitialInterface();
            switch (chooseMenu)
            {
                case 1:
                    showAllAccounts();
                    break;
                case 2:
                    createNewAccount();
                    break;
                case 3:
                    updateAccount();
                    break;
                case 4:
                    getAccountById();
                    break;
                case 5:
                    deleteAccount();
                    break;
                default:
                    break;
            }
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
            int chooseMenu = menu.updateIfAccountFoundMenu();
            string update = "";
            if (chooseMenu == 1) {update = menu.updateAccountName();}
            else if(chooseMenu == 2) {}
            controllereAccount.updateAccountName(foundedAccount.Id, update);
        }

        static public void deleteAccount()
        {
            AccountTable foundedAccount = controllereAccount.getAccountById(menu.getAccountByIdMenu());
            menu.showAccount(foundedAccount);
            int chooseMenu = menu.deleteAccount();
            if(chooseMenu != 0)
            {
                controllereAccount.deleteAccount(foundedAccount.Id);
            }
        }
    }
}
