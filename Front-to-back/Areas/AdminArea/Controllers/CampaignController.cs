﻿using Front_to_back.Data;
using Front_to_back.Helpers.Enums;
using Front_to_back.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    [Authorize(Roles = "Admin")]
    public class CampaignController : Controller
    {
        private readonly AppDbContext _context;
        public CampaignController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Campaign.Count() / 2);
            ViewBag.CurrentPage = page;
            List<Campaign> campaigns = _context.Campaign.Skip((page - 1) * 2).Take(2).ToList();

            return View(campaigns);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Campaign campaign)
        {
            List<Campaign> percent = _context.Campaign.Where(hs => hs.DiscountPercent == campaign.DiscountPercent).ToList();
            if (!ModelState.IsValid)
            {
                return View();
            }
            foreach (var item in percent)
            {
                if (item.DiscountPercent == campaign.DiscountPercent)
                {
                    ModelState.AddModelError("DiscountPercent", "Percent already have.Write other percent");
                    return View(campaign);
                }
            }
            if (!(campaign.DiscountPercent >= 0 && campaign.DiscountPercent <= 100))
            {
                ModelState.AddModelError("DiscountPercent", "Percent must be between 0 and 100");
                return View(campaign);
            }
            _context.Campaign.Add(campaign);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int id)
        {
            Campaign campaign = _context.Campaign.FirstOrDefault(c => c.Id == id);
            return View(campaign);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Campaign campaign, int id)
        {
            Campaign percent = _context.Campaign.FirstOrDefault(hs => hs.DiscountPercent == campaign.DiscountPercent);
            if (!ModelState.IsValid)
            {
                return View();
            }
            Campaign existedCampaign = _context.Campaign.FirstOrDefault(c => c.Id == campaign.Id);
            if (existedCampaign == null)
            {
                return NotFound();
            }

            if (percent != null && percent.Id != id)
            {
                ModelState.AddModelError("DiscountPercent", "Percent already have.Write other percent");
                return View(existedCampaign);
            }
            if (!(campaign.DiscountPercent >= 0 && campaign.DiscountPercent <= 100))
            {
                ModelState.AddModelError("DiscountPercent", "Percent must be between 0 and 100");
                return View(campaign);
            }
            existedCampaign.DiscountPercent = campaign.DiscountPercent;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Campaign campaign = _context.Campaign.FirstOrDefault(c => c.Id == id);
            if (campaign == null) return Json(new { status = 404 });

            _context.Campaign.Remove(campaign);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }
    }
}
