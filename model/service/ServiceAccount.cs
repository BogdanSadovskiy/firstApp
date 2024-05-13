using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstApp.entity;
using firstApp.model.repository.RepositoryAccount;
using System.Data.SqlClient;
namespace firstApp.model.service
{
    class ServiceAccount
    {

        string connectionString = "Server=tcp:bogdanserver.database.windows.net,1433;" +
            "Initial Catalog=db;Persist Security Info=False;User ID=CloudSA95db027a;Password=Workout100500;" +
            "MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        RepositoryAccount repository = new RepositoryAccount();
        public List<AccountTable> getAllAccounts()
        {
            List<AccountTable> accounts = null;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    accounts = repository.getAllAccounts(connection);
                }

                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return accounts;
        }

        public int createNewAccount(string name, string  email, string password)
        {
            int id = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    id = repository.createNewAccount(connection, name, email, password);
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return id;
        }

    }
}
