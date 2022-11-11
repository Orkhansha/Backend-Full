
using Front_to_back.Models;
using System;
using System.Collections.Generic;

namespace Front_to_back.ViewModels.ProductViewModels
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string Images { get; set; }
        public string CategoryName { get; set; }
        public string MainImage { get; set; }
        public int Discount { get; set; }
        public int SellerCount { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
        public Product Product { get; set; }
    }
}
