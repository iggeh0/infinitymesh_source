using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using infinitymesh_test.DAL.Models;
using infinitymesh_test.DAL.ViewModels;

namespace infinitymesh_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly TempDB _context;

        public HomeController(TempDB context)
        {
            _context = context;
        }
        public ActionResult Index()
        {
            return View("login");
        }

        public ActionResult EditProfile(int id)
        {
            UserProfileVM Model = new UserProfileVM();
            _context.Users.ToList();
            _context.Blogs.ToList();
            var service = new BlogService(_context);
            Model.User = service.FindUser(id);
            Model.Blogs = service.FindBlogs(id);
            return View("EditProfile", Model);
        }



        public async Task<ActionResult> LoginCheck(string username, string password)
        {
            if (username != null && username.Length > 3 && password != null && password.Length > 3)
            {
                await _context.Users.ToListAsync();
                await _context.Blogs.ToListAsync();
                foreach (Users u in _context.Users)
                {
                    if (u.Username == username && u.Password == password)
                    {
                        UserHomeVM Model = new UserHomeVM
                        {
                            Blogs = new List<Blogs>(),
                            Users = new List<Users>()
                        };
                        foreach (Users Q in _context.Users)
                        {
                            if (Q.Id == u.Id)
                            {
                                Model.User = new Users(Q);
                            }
                            else
                            {
                                Model.Users.Add(Q);
                            }
                        }
                        foreach (Blogs b in _context.Blogs)
                        {
                            if (b.UserID != u.Id)
                            {
                                Model.Blogs.Add(b);
                            }
                        }
                        return View("Home", Model);
                    }
                }

            }
            LoginErrorVM Error = new LoginErrorVM();
            return View("Login", Error);
        }
    }
}