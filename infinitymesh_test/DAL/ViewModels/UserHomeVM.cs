using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using infinitymesh_test.DAL.Models;

namespace infinitymesh_test.DAL.ViewModels
    {
    public class UserHomeVM
        {
            public List<Users> Users;

            public UserHomeVM()
        {
            Users = new List<Users>();
        }
        }
    }