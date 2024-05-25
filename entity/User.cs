﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstApp.entity
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName {get; set; }
        public string LastName {get; set; }
        public string PhoneNumber { get; set; } 
        public string Email { get; set; }
        public string Password { get; set; }
        public int RoleId { get; set; }


        public User(int id, string firstName, string lastName, string phoneNumber, string email, string password, int roleId)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Email = email;
            Password = password;
            RoleId = roleId;
        }
    }
}