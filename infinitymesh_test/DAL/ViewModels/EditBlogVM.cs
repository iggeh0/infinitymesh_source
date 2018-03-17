using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace infinitymesh_test.DAL.ViewModels
    {
    public class EditBlogVM
        {
            int? BlogID;
            public string Title;
            public string Summary;
            public string Content;
            public DateTime? PublishedDateTime;
            public int? UserID;
        }
    }