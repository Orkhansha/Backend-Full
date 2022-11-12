
using Front_to_back.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Front_to_back.ViewModels.ProductViewModels
{
    public class ProductListVM
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "decimal(18,4)")]
        public decimal Price { get; set; }
        public string Images { get; set; }
        public string CategoryName { get; set; }
        public string ProductColor { get; set; }
        public string ProductSize { get; set; }
        public string MainImage { get; set; }
        public int Discount { get; set; }
        public int SellerCount { get; set; }
        public Category Category { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public ShopBanner ShopBanner { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
        public Product Product { get; set; }
    }
}
