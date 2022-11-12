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

        //public async Task<IActionResult> Index(int page = 1, int take = 6)
        //{
        //    IEnumerable<Category> categories = await _context.Categories.ToListAsync();
        //    IEnumerable<Color> colors = await _context.Colors.ToListAsync();
        //    IEnumerable<Size> sizes = await _context.Sizes.ToListAsync();
        //    ShopBanner shopBanner = await _context.ShopBanners.FirstOrDefaultAsync();
        //    //BlogHead blogHeads = await _context.BlogHeads.FirstOrDefaultAsync();
        //    //IEnumerable<Service> services = await _context.Services.ToListAsync();
        //    //IEnumerable<Category> categories = await _context.Categories.Where(m => m.IsDeleted == false).ToListAsync();
        //    List<Product> products = await _context.Products
        //        .Where(m => m.IsDeleted == false)
        //        .Include(m => m.Category)
        //        .Include(m => m.ProductImages)
        //        .Skip((page*take)-take)
        //        .Take(take)
        //        .ToListAsync();



        //    List<ProductListVM> mapDatas = GetMapDatas(products);

        //    int count = await GetPageCount(take);

        //    Paginate<ProductListVM> result = new Paginate<ProductListVM>(mapDatas, page, count);

        //    //ShopVM model = new ShopVM
        //    //{
        //    //    Categories = categories,
        //    //    Products = products,
        //    //    Sizes = sizes,
        //    //    Colors = colors,
        //    //    ShopBanner = shopBanner, 



        //    //};

        //    return View(result);
        //}


        //private async Task<int> GetPageCount(int take)
        //{
        //    int productCount = await _context.Products.Where(m => !m.IsDeleted).CountAsync();
        //    return (int)Math.Ceiling((decimal)(productCount / take));
        //}


        //private List<ProductListVM> GetMapDatas(List<Product> products)
        //{
        //    List<ProductListVM> productList = new List<ProductListVM>();
        //    foreach (var product in products)
        //    {
        //        ProductListVM newProduct = new ProductListVM
        //        {
        //            Id = product.Id,
        //            Title = product.Title,
        //            //Desription = products.descr
        //            MainImage = product.ProductImages.Where(m => m.IsMain).FirstOrDefault()?.Image,
        //            CategoryName = product.Category.Name,
        //            Price = product.Price,
        //            ProductColor = product.Color.Name,
        //            ProductSize = product.Size.Name
        //        };

        //        productList.Add(newProduct);
        //    }

        //    return productList;
        //}


        public async Task<IActionResult> Index(int sortId, int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Products.Count() / 6);
            ViewBag.CurrentPage = page;
            ViewBag.Categories = _context.Categories.Include(c => c.ProductCategories).ThenInclude(bc => bc.Product).ToList();
            IEnumerable<Category> categories = await _context.Categories.Where(m => !m.IsDeleted).ToListAsync();
            ViewBag.Colors = await _context.Colors.ToListAsync();
            ViewBag.Sizes = await _context.Sizes.ToListAsync();
            ViewBag.ShopBanner = await _context.ShopBanners.FirstOrDefaultAsync();

            List<Product> products = _context.Products.Include(f => f.ProductCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Skip((page - 1) * 3).Take(3).ToList();
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
