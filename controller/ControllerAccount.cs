using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstApp.entity;
using firstApp.model.service;

namespace firstApp.controller.controllerAccount
{
    public class ControllereAccount
    {
        private ServiceAccount serviceAccount = new ServiceAccount();
        public List<AccountTable> getAllAccounts()
        {

            return serviceAccount.getAllAccounts();
        }

        public int createNewAccount(string name, string email, string password)
        {
            return serviceAccount.createNewAccount(name, email, password);
        }
        public AccountTable getAccountById(int id)
        {
            return serviceAccount.getAccountById(id);
        }
        public void updateAccountName(int id, string newName)
        {
            serviceAccount.updateAccountName(id, newName);
        }
    }
}
