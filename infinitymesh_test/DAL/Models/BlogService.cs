using System;
using System.Collections.Generic;
using System.Linq;
using infinitymesh_test.DAL.Models;

namespace infinitymesh_test.DAL.Models
{
    public class BlogService
    {
        private TempDB _context;

        public BlogService(TempDB context)
        {
            _context = context;
        }



        public void AddBlogs(string Title, string Summary, string Content, DateTime PublishedDateTime, int UserID)
        {
            Blogs newBlog = new Blogs
            {
                Title = Title,
                Summary = Summary,
                Content = Content,
                PublishedDateTime = PublishedDateTime,
                UserID = UserID
            };
            _context.Blogs.Add(newBlog);
            _context.SaveChanges();
        }

        public void AddBlogs(Blogs b)
        {
            _context.Blogs.Add(b);
            _context.SaveChanges();
        }

        public List<Blogs> FindBlogs(int userId)
        {
            return _context.Blogs
                .Where(b => b.UserID == userId)
                .OrderBy(b => b.PublishedDateTime)
                .ToList();
        }

        public void AddUser(Users u)
        {
            Users newUser = new Users(u);
            _context.Add(newUser);
            _context.SaveChanges();
        }

        public void AddUser(string Name, int Age, string Username, string Email, string Password)
        {
            Users newUser = new Users
            {
                Name = Name,
                Age = Age,
                Email = Email,
                Password = Password,
                Username = Username
            };
            _context.Add(newUser);
            _context.SaveChanges();
        }

        public Users FindUser(int userId)
        {
            return _context.Users.Where(x => x.Id == userId).Single();
                
        }

    }
}