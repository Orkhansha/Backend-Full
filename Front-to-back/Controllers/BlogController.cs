using Front_to_back.Data;
using Front_to_back.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    public class BlogController : Controller
    {
        private AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogDetails(int? id)
        {
            Blog blog = _context.Blogs.FirstOrDefault(b=>b.Id==id);
            return View(blog );
        }

       

    }
}
