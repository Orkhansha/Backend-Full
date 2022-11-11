using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Models
{
    public class Banner: BaseEntity
    {
        public string Image { get; set; }
        public string Subtitle { get; set; }
        public string Title { get; set; }

    }
}
