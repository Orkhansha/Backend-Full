using Front_to_back.Data;
using Front_to_back.Models;
using Front_to_back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Controllers
{
    

    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Slider> sliders = await _context.Sliders.ToListAsync();
            IEnumerable<Blog> blogs = await _context.Blogs.ToListAsync();
            IEnumerable<Brand> brands = await _context.Brands.ToListAsync();
            IEnumerable<Category> categories = await _context.Categories.ToListAsync();
            IEnumerable<Banner> banners = await _context.Banners.ToListAsync();
            BlogHead blogHeads = await _context.BlogHeads.FirstOrDefaultAsync();
            IEnumerable<Service> services = await _context.Services.ToListAsync();
            IEnumerable<Product> products = await _context.Products
                .Where(m => m.IsDeleted == false)
                .Include(m => m.ProductCategories).ThenInclude(m=>m.Category)
                .Include(m => m.ProductImages).Take(4).ToListAsync();

            HomeVM model = new HomeVM
            {
                Sliders = sliders,
                Categories = categories,
                Products = products,
                Services = services,
                Banners = banners,
                BlogHead = blogHeads,
                Blogs = blogs,
                Brands = brands
            };

            return View(model);
        }

        
       

        //private void UpdateBasket(List<BasketVM> basket, int id)
        //{
        //    BasketVM existProduct = basket.FirstOrDefault(m => m.Id == id);

        //    if (existProduct == null)
        //    {
        //        basket.Add(new BasketVM
        //        {
        //            Id = id,
        //            Count = 1
        //        });
        //    }
        //    else
        //    {
        //        existProduct.Count++;
        //    }
        //}

        //private async Task<Product> GetProductById(int? id)
        //{
        //    return await _context.Products.FindAsync(id);
        //}


        //private List<BasketVM> GetBasket()
        //{
        //    List<BasketVM> basket;

        //    if (Request.Cookies["basket"] != null)
        //    {
        //        basket = JsonConvert.DeserializeObject<List<BasketVM>>(Request.Cookies["basket"]);
        //    }
        //    else
        //    {
        //        basket = new List<BasketVM>();
        //    }

        //    return basket;
        //}


    }
}
