using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstApp.entity;
using firstApp.model.repository.RepositoryAccount;
using System.Data.SqlClient;
using System.Runtime.Remoting.Channels;
using System.Configuration;
namespace firstApp.model.service
{
    class UserService
    {
        string connectionString = ConfigurationManager.ConnectionStrings["db_connectionString"].ConnectionString;
        UserRepository repository = new UserRepository();
        public List<User> getAllUsers()
        {
            List<User> accounts = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    accounts = repository.getAllUsers(connection);
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return accounts;
        }

        //public int createNewAccount(string name, string  email, string password)
        //{
        //    int id = 0;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            repository.createNewAccount(connection, name, email, password);
        //        }

        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //    return id;
        //}
        //public User getAccountById(int id)
        //{
        //    User account = null;
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            account = repository.getAccountById(connection, id);
        //        }

        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //        return account;
        //    }
        //}

        //public void updateAccountName(int id, string newName)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            repository.updateAccountName(connection,id, newName);
        //        }
        //        catch(Exception ex)
        //        {
        //            Console.WriteLine("\n" + ex.Message + "\n");
        //        }
        //    }

            
            
        //}

        //public void deleteAccount(int id)
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //            repository.deleteAccount(connection,id);
        //        }
        //        catch(Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
        //    }
        //}
        //public User SighIn(string login, string password)
        //{
        //    User account = null;
        //    using(SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();
        //           account = repository.SighIn(connection, login, password);
        //        }
        //        catch(Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }
                
        //    }
        //    return account;
        //}
    }
}
