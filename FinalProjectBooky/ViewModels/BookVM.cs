using FinalProjectBooky.Models;
using System.Collections.Generic;

namespace FinalProjectBooky.ViewModels
{
    public class BookVM
    {
        public int BookId { get; set; }
        public Book Book { get; set; }
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }
        public int CampaignId { get; set; }
        public Campaign Campaign { get; set; }
    }
}
