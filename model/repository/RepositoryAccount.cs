using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using firstApp.entity;
using System.Data.SqlClient;
namespace firstApp.model.repository.RepositoryAccount
{
    public class RepositoryAccount
    {
        
        public List<AccountTable> getAllAccounts(SqlConnection connection)
        {
          
            List<AccountTable> accountTables = new List<AccountTable>();
            string query = "SELECT * from account";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string name = Convert.ToString(reader["name"]);
                        string email = Convert.ToString(reader["email"]);
                        string password = Convert.ToString(reader["password"]);
                        AccountTable account = new AccountTable(id, name, email, password);
                        accountTables.Add(account);
                    }
                }
            }
            return accountTables;
        }

        public int createNewAccount(SqlConnection connection , string name, string email, string password)
        {
            string query = $"INSERT INTO account value ('{name}','{email}'','{password}');";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string name = Convert.ToString(reader["name"]);
                        string email = Convert.ToString(reader["email"]);
                        string password = Convert.ToString(reader["password"]);
                        AccountTable account = new AccountTable(id, name, email, password);
                        accountTables.Add(account);
                    }
                }
            }
        }
}
