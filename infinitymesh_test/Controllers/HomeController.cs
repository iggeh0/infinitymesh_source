using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using infinitymesh_test.DAL.Models;
using infinitymesh_test.DAL.ViewModels;
using PagedList;
using System;

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
            LoginErrorVM Model = new LoginErrorVM();
            return View("login", Model);
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

        public async Task<ActionResult> HomePage(
            string currentFilter,
            string searchString,
            int? page)
        {
            await _context.Users.ToListAsync();
            await _context.Blogs.ToListAsync();

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            int? currentpage = page;
            int pageSize = 5;


            var Users = from w in _context.Users
                        select w;
            if (!String.IsNullOrEmpty(searchString))
            {
                Users = Users.Where(s => s.Name.Contains(searchString)
                                       || s.Email.Contains(searchString));
            }
            foreach (Blogs b in _context.Blogs)
            {
                Users.Where(x => x.Id == b.UserID).Single().BlogNumber++;
            }
            return View("Home", await PaginatedList<Users>.CreateAsync(Users.AsTracking(), currentpage ?? 1, pageSize));
        }

        public ActionResult GetBlogInfo(int id)
        {
            _context.Blogs.ToList();
            BlogService service = new BlogService(_context);
            Blogs b = service.GetBlog(id);
            return this.Json(b);
        }

        public int CreateBlog(Blogs data)
        {
            _context.Blogs.ToList();
            _context.Blogs.Add(data);
            _context.SaveChanges();
            return _context.Blogs.Last().Id;
        }

        public void UpdateBlog(Blogs data)
        {
            _context.Users.ToList();
            _context.Blogs.ToList();
            var service = new BlogService(_context);
            Blogs current = service.GetBlog(data.Id);
            current.Title = data.Title;
            current.Summary = data.Summary;
            current.PublishedDateTime = data.PublishedDateTime;
            current.Content = data.Content;

            _context.Blogs.Update(current);
            _context.SaveChanges();
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
                        var Users = from w in _context.Users
                                       select w;
                        foreach (Blogs b in _context.Blogs)
                        {
                            Users.Where(x => x.Id == b.UserID).Single().BlogNumber++;
                        }
                        int? page = 1;
                        int pageSize = 5;
                        

                        return View("Home", await PaginatedList<Users>.CreateAsync(Users.AsTracking(), page ?? 1, pageSize));
                    }
                }

            }
            LoginErrorVM Error = new LoginErrorVM
            {
                ErrorFound = true
            };
            return View("login", Error);
        }
    }
}