using firstApp.entity;
using firstApp.model.service;
using System.Collections.Generic;

namespace firstApp.controller.controllerAccount
{
    public class UserController
    {
        private UserService userService = new UserService();
        public List<User> getAllUsers()
        {

            return userService.getAllUsers();
        }

        //    public int createNewAccount(string name, string email, string password)
        //    {
        //        return serviceAccount.createNewAccount(name, email, password);
        //    }
        //    public User getAccountById(int id)
        //    {
        //        return serviceAccount.getAccountById(id);
        //    }
        //    public void updateAccountName(int id, string newName)
        //    {
        //        serviceAccount.updateAccountName(id, newName);
        //    }

        //    public void deleteAccount(int id)
        //    {
        //        serviceAccount.deleteAccount(id);
        //    }

        //    public User SighIn(string login, string password)
        //    {
        //        return serviceAccount.SighIn(login, password);
        //    }
    }
}
