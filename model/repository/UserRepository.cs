﻿using firstApp.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
namespace firstApp.model.repository.RepositoryAccount
{
    public class UserRepository
    {

        public List<User> getAllUsers(SqlConnection connection)
        {

            List<User> users = new List<User>();
            string query = "SELECT * from users;";
            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["id"]);
                        string firstName = Convert.ToString(reader["fname"]);
                        string lastName = Convert.ToString(reader["sname"]);
                        string phoneNumber = Convert.ToString(reader["number_of_telephone"]);
                        string email = Convert.ToString(reader["email"]);
                        string password = Convert.ToString(reader["password"]);
                        int roleId = Convert.ToInt32(reader["role_id"]);
                        User user = new User(id, firstName, lastName, phoneNumber,  email, password, roleId);
                        users.Add(user);
                    }
                }
            }
            return users;
        }

        //public void createNewAccount(SqlConnection connection, string name, string email, string password)
        //{
        //    string query = $"INSERT INTO accounts  output inserted.id  values ('@name, @email, @password) ;";

        //    using (SqlCommand cmd = new SqlCommand(query, connection))
        //    {
        //        cmd.Parameters.Add("@name", System.Data.SqlDbType.NVarChar).Value = name;
        //        cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = email;
        //        cmd.Parameters.Add("@password", System.Data.SqlDbType.NVarChar).Value = password;
        //        int id = (int)cmd.ExecuteScalar();
        //        Console.WriteLine("you created id - " + id);
        //    }
        //}

        //public User getAccountById(SqlConnection connection, int id)
        //{
        //    User account = null;
        //    string query = "SELECT * FROM accounts WHERE id = " + id.ToString() + ";";
        //    using (SqlCommand cmd = new SqlCommand(query, connection))
        //    {
        //        using (SqlDataReader reader = cmd.ExecuteReader())
        //        {
        //            while (reader.Read())
        //            {
        //                int recivedId = Convert.ToInt32(reader["id"]);
        //                string name = Convert.ToString(reader["name"]);
        //                string email = Convert.ToString(reader["email"]);
        //                string password = Convert.ToString(reader["password"]);
        //                account = new User(recivedId, name, email, password);
        //            }
        //        }
        //    }
        //    return account;
        //}

        //public void updateAccountName(SqlConnection connection, int id, string newName)
        //{
        //    string query = "UPDATE  accounts SET name = @newName  WHERE id = " + id.ToString();

        //    using (SqlCommand cmd = new SqlCommand(query, connection))
        //    {
        //        cmd.Parameters.Add("@newName", System.Data.SqlDbType.NVarChar).Value = newName;
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public void deleteAccount(SqlConnection connection,int id)
        //{
        //    string query = "DELETE FROM accounts WHERE ID = @id";
        //    using(SqlCommand cmd = new SqlCommand(query,connection))
        //    {
        //        cmd.Parameters.Add("@id", System.Data.SqlDbType.Int).Value = id;
        //        cmd.ExecuteNonQuery();
        //    }
        //}

        //public User SighIn(SqlConnection connection, string login, string password)
        //{

        //}
    }
}
