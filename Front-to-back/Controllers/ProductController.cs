using Front_to_back.Data;
using Front_to_back.Models;
using Front_to_back.ViewModels;
using Front_to_back.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        public ProductController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IActionResult> Index(int? id)
        {
            Product products = await _context.Products
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.ProductImages).FirstOrDefaultAsync();


            ProductVM model = new ProductVM
            {
                Products = products,
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            AppUser user = new AppUser();
            if (User.Identity.IsAuthenticated)
            {
                user = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            Product products = await _context.Products
                .Where(m => !m.IsDeleted && m.Id == id)
                .Include(m => m.ProductImages).FirstOrDefaultAsync();


            ProductVM model = new ProductVM
            {
                Products = products,
                Comments = _context.Comments.Include(c => c.Product).Include(c => c.AppUser).Where(c => c.ProductId == id).ToList()

            };

            return View(model);
        }
        public IActionResult Affiliate()
        {
            return View();
        }

        public IActionResult Variable()
        {
            return View();
        }

        public IActionResult Group()
        {
            return View();
        }

        public IActionResult Search(string search)
        {
            List<Product> products = _context.Products.Where(p => p.Title.ToLower().Contains(search.ToLower())).ToList();
            return PartialView("_Search", products);
        }
        public IActionResult Searche(string search)
        {
            List<Product> products = _context.Products.Where(p => p.Title.ToLower().Contains(search.ToLower())).ToList();
            return PartialView("_Search", products);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user == null)
            {
                return RedirectToAction("login", "account");
            }
            if (!_context.Products.Any(f => f.Id == comment.ProductId)) return NotFound();
            Comment cmnt = new Comment
            {
                Message = comment.Message,
                ProductId = comment.ProductId,
                Date = DateTime.Now,
                AppUserId = user.Id
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();
            return RedirectToAction("Detail", "product", new { id = comment.ProductId });

        }
        public async Task<IActionResult> DeleteComment(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Detail", "product");
            if (!_context.Comments.Any(c => c.Id == id && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Detail", "product", new { id = comment.ProductId });
        }
    }
}
