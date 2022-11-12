using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Front_to_back.Models
{
    public class AppUser : IdentityUser
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; } = false;
        public List<BasketItem> BasketItems { get; set; }

        public List<Comment> Comments { get; set; }
    }
}
