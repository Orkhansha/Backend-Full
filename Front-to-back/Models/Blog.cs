using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Front_to_back.Models
{
    public class Blog: BaseEntity
    {
        public string Image { get; set; }
        public string Title { get; set; }
        public string Creator { get; set; }
        public DateTime CreateTime { get; set; }
    }
}
