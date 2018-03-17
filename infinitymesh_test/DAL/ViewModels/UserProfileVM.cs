using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using infinitymesh_test.DAL.Models;

namespace infinitymesh_test.DAL.ViewModels
    {
    public class UserProfileVM
        {
            public Users User;
            public List<Blogs> Blogs;
            
          public UserProfileVM()
        {
            Blogs = new List<Blogs>();
        }
        }
    }