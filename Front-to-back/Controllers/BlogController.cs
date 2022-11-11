using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogDetails()
        {
            return View();
        }

        public IActionResult BlogRight()
        {
            return View();
        }

        public IActionResult NoSidebar()
        {
            return View();
        }

        public IActionResult BlogAudio()
        {
            return View();
        }

        public IActionResult BlogVideo()
        {
            return View();
        }

        public IActionResult BlogDetailsLeft()
        {
            return View();
        }

    }
}
