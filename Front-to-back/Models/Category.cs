using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Models
{
    public class Category: BaseEntity
    {
        [Required(ErrorMessage = "Name can't be empty")]
        public string Name { get; set; }
        public ICollection<Product> Products { get; set; }
        public int Count { get; set; }

    }
}
