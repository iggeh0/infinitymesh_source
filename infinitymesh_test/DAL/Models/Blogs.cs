using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace infinitymesh_test.DAL.Models
    {
    public class Blogs
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Summary { get; set; }
            public string Content { get; set; }
            public DateTime PublishedDateTime { get; set; }
            public int UserID { get; set; }
            public Blogs()
            {
            }
             public Blogs(string Title, string Summary, string Content, DateTime PublishedDateTime, int UserID)
            {
                this.Title = Title;
                this.Summary = Summary;
                this.Content = Content;
                this.PublishedDateTime = PublishedDateTime;
                this.UserID = UserID;
            }
    }
    }