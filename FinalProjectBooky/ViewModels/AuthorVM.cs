using FinalProjectBooky.Models;
using System.Collections.Generic;

namespace FinalProjectBooky.ViewModels
{
    public class AuthorVM
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
    }
}
