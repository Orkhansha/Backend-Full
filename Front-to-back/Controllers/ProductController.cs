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
        public IActionResult Detail(int id, int categoryId)
        {

            Product product = _context.Products.Include(b => b.Comments).Include(b => b.ProductCategories).ThenInclude(bc => bc.Category).Include(b => b.Campaign).FirstOrDefault(b => b.Id == id);
            if (product == null)
            {
                return NotFound();
            }
             


            List<Category> categories = _context.Categories.Include(c => c.ProductCategories).ThenInclude(bc => bc.Product).ThenInclude(bcb => bcb.Comments).Where(b => b.ProductCategories.Any(bc => bc.ProductId == id)).ToList();

            List<Product> relatedProducts = new List<Product>();

            foreach (var item in categories)
            {
                relatedProducts = _context.Products.Include(b => b.Comments).Include(b => b.Campaign).Include(b => b.ProductCategories).ThenInclude(bc => bc.Category).Where(b => b.ProductCategories.Any(bc => bc.CategoryId == item.Id)).Skip(1).Take(4).ToList();
            }

            ProductDetailVM bookDetailVM = new ProductDetailVM()
            {
                Comments = _context.Comments.Include(c => c.Product).Include(c => c.AppUser).Where(c => c.ProductId == id).ToList(),
                RelatedProducts = relatedProducts,
                Categories = categories,
                Product = product,
            };

            return View(bookDetailVM);

        }

        public async Task<IActionResult> AddBasket(int id,int count)
        {
            Product product = _context.Products.Include(f => f.Campaign).FirstOrDefault(f => f.Id == id);


            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.ProductId == product.Id && b.AppUserId == user.Id);
                
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        ProductId = product.Id,
                        Count = count
                    };
                    _context.BasketItems.Add(basketItem);
                
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));


                //return View("_basketPartial");
            }



            return RedirectToAction("login", "account");
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
