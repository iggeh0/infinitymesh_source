using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace infinitymesh_test.DAL.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Users()
        {

        }

        public Users(string Name, int Age, string Username, string Email, string Password)
        {
            this.Name = Name;
            this.Age = Age;
            this.Email = Email;
            this.Password = Password;
            this.Username = Username;

        }

        public Users(Users u)
        {
            this.Id = u.Id;
            this.Name = u.Name;
            this.Age = u.Age;
            this.Email = u.Email;
            this.Username = u.Username;
            this.Password = u.Password;
        }
    }
}