using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace FinalProjectBooky.Models
{
    public class AppUser:IdentityUser
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<WishListItem> WishListItems { get; set; }

        public bool? IsAdmin { get; set; }
    }
}
