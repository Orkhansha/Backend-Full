using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Models
{
    public class Campaign
    {
        public int Id { get; set; }
        [Required]
        public int DiscountPercent { get; set; }
        public List<Product> Products { get; set; }
    }
}
