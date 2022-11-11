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
        public string Title { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        public int Discount { get; set; }
        public int SellerCount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
        //public ProductImages ProductImages { get; set; }
    }
}
