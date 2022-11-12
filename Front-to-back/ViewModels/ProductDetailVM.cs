using Front_to_back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.ViewModels
{
    public class ProductDetailVM
    {
        public Product Product { get; set; }
        public List<Product> RelatedProducts{ get; set; }
        public List<Category> Categories { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
