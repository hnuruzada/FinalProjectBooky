using FinalProjectBooky.Models;
using System.Collections.Generic;

namespace FinalProjectBooky.ViewModels
{
    public class DashboardVM
    {
        public List<Book> Books { get; set; }
        public List<Order> Orders { get; set; }
        public List<AppUser> AppUsers { get; set; }
        public List<Contact> Contacts {  get; set; }
        public List<Comment> Comments { get; set; }
    }
}
