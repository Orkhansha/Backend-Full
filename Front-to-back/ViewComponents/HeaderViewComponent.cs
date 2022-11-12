using Front_to_back.Data;
using Front_to_back.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;
        private UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<Currency> currency = _context.Currencies.ToList();
            List<Language> language = _context.Languages.ToList();
            ViewBag.Currency = currency;
            ViewBag.Language = language;
            if (User.Identity.IsAuthenticated)
            {

                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                Bio bios = _context.Bios.FirstOrDefault();
                List<BasketItem> item = _context.BasketItems.Include(b => b.Product).Where(b => b.AppUserId == user.Id).ToList();
                if (item.Count>0)
                {
                    ViewBag.BasketCount = item.Count;

                }
                else
                {
                ViewBag.BasketCount =0;

                }
               

                return View(await Task.FromResult(bios));
            }
            else
            {
                Bio bios = _context.Bios.FirstOrDefault();
                ViewBag.BasketCount = 0;
                return View(await Task.FromResult(bios));
            }
        }
    }
}
