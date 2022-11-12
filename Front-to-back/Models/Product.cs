using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Models
{
    public class Product: BaseEntity
    {
        public string Image { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string Title { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Discount { get; set; }
        public int SellerCount { get; set; }
       
        public Color Color { get; set; }
        public Size Size { get; set; }
        public List<Comment> Comments { get; set; }
        public int? CampaignId { get; set; }
        public Campaign Campaign { get; set; }
        [NotMapped]
        public List<int> CategoryIds { get; set; }
        public List<ProductCategories> ProductCategories { get; set; }

        public ICollection<ProductImages> ProductImages { get; set; }
        //public ProductImages ProductImages { get; set; }
    }
}
