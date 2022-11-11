using Front_to_back.Data;
using Front_to_back.Models;
using Front_to_back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            IEnumerable<Color> colors = await _context.Colors.ToListAsync();
            IEnumerable<Size> sizes = await _context.Sizes.ToListAsync();
            ShopBanner shopBanner = await _context.ShopBanners.FirstOrDefaultAsync();
            //BlogHead blogHeads = await _context.BlogHeads.FirstOrDefaultAsync();
            //IEnumerable<Service> services = await _context.Services.ToListAsync();
            //IEnumerable<Category> categories = await _context.Categories.Where(m => m.IsDeleted == false).ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Where(m => m.IsDeleted == false)
                .Include(m => m.Category)
                .Include(m => m.ProductImages)./*Take(4)*/ToListAsync();

            ShopVM model = new ShopVM
            {
                Categories = categories,
                Products = products,
                Sizes = sizes,
                Colors = colors,
                ShopBanner = shopBanner
            };

            return View(model);
        }

        public IActionResult GridRight()
        {
            return View();
        }

        public IActionResult GridFull3()
        {
            return View();
        }

        public IActionResult GridFull4()
        {
            return View();
        }

        public IActionResult ListFull()
        {
            return View();
        }

        public IActionResult ListRight()
        {
            return View();
        }

        public IActionResult ListLeft()
        {
            return View();
        }


    }

}
