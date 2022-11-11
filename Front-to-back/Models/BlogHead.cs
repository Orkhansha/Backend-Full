using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Models
{
    public class BlogHead: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
