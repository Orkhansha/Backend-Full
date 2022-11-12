using Front_to_back.Helpers;
using Front_to_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.ViewModels
{
    public class ShopVM
    {
        public IEnumerable<Banner> Banners { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<Color> Colors { get; set; }
        public IEnumerable<Size> Sizes { get; set; }
        public BlogHead BlogHead { get; set; }
        public ShopBanner ShopBanner { get; set; }
        
    }
}
