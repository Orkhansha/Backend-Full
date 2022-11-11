using Front_to_back.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.ViewModels.ProductViewModels
{
    public class ProductCreateVM
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Price { get; set; }
        [Required]
        public string Description { get; set; }
        public ProductImages ProductImages { get; set; }
        public DateTime CreateTime { get; set; }
        public int CategoryId { get; set; }
        [Required]
        public List<IFormFile> Photos { get; set; }
    }
}
