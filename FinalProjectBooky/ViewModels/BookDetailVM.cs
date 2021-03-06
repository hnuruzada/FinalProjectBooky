using FinalProjectBooky.Models;
using System.Collections.Generic;

namespace FinalProjectBooky.ViewModels
{
    public class BookDetailVM
    {
        public Book Book { get; set; }
        public List<Book> RelatedBooks { get; set; }
        public List<Category> Categories { get; set; }
        public List<Comment> Comments { get; set; }
        
    }
}
