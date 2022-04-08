using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public List<BookCategory> BookCategories { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
