using Front_to_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.ViewModels
{
    public class BasketItemVM
    {
        public Product Product { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
    }
}
