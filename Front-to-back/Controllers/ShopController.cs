using Front_to_back.Data;
using Front_to_back.Helpers;
using Front_to_back.Models;
using Front_to_back.ViewModels;
using Front_to_back.ViewModels.ProductViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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

        public async Task<IActionResult> Index(int sortId, int page = 1, int take =6)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Products.Count() / 6);
            ViewBag.CurrentPage = page;
            ViewBag.Categories = _context.Categories.Include(c => c.ProductCategories).ThenInclude(bc => bc.Product).ToList();
            //IEnumerable<Category> categories = await _context.Categories.Where(m => !m.IsDeleted).ToListAsync();
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();
            ViewBag.ShopBanner = await _context.ShopBanners.FirstOrDefaultAsync();
            List<Product> products = _context.Products
                .Include(f => f.ProductCategories).ThenInclude(fc => fc.Category)
                .Include(f => f.Campaign).Skip((page*take) - take).Take(take).ToList();
            ViewBag.take = take;
            List<Product> mapDatas = products;
            int count = await GetPageCount(take);
            Paginate<Product> result = new Paginate<Product>(mapDatas, page, count);
            ViewBag.Paginate = result;

            //List<Product> products = _context.Products.Include(f => f.ProductCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Skip((page - 1) * 6).Take(6).ToList();
            ViewBag.id = sortId;

            switch (sortId)
            {
                case 1:
                    products = _context.Products.Include(f => f.ProductCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).ToList();
                    break;
                case 3:
                    products = _context.Products.Include(f => f.ProductCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).OrderByDescending(s => s.Title).ToList();
                    break;
                case 2:
                    products = _context.Products.Include(f => f.ProductCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).OrderBy(s => s.Title).ToList();
                    break;
                case 5:
                    products = _context.Products.Include(f => f.ProductCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).OrderByDescending(s => s.CampaignId == null ? s.Price : (s.Price * (100 - s.Campaign.DiscountPercent) / 100)).ToList();
                    break;
                case 4:
                    products = _context.Products.Include(f => f.ProductCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).OrderBy(s => s.CampaignId == null ? s.Price : (s.Price * (100 - s.Campaign.DiscountPercent) / 100)).ToList();
                    break;
                default:

                    break;
            }
            return View(products);
        }

        //private List<Product> GetMapDatas(List<Product> products)
        //{
        //    List<Product> productList = new List<Product>();

        //    foreach (var product in products)
        //    {
        //        Product newProduct = new Product
        //        {
        //            Id = product.Id,
        //            Title = product.Title,
        //            Image = product.Image,
        //            ProductImages = product.ProductImages.Where(m => !m.IsDeleted).ToList(),
        //            //CategoryName = product.ProductCategories,
        //            Price = product.Price,
        //            SellerCount = product.SellerCount,
        //            Discount = product.Discount
        //        };

        //        productList.Add(newProduct);
        //    }

        //    return productList;
        //}

        private async Task<int> GetPageCount(int take)
        {
            int productCount = await _context.Products.Where(m => !m.IsDeleted).CountAsync();

            return (int)Math.Ceiling((decimal)productCount / take);
        }
    }

}
