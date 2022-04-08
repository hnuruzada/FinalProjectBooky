using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class Tag
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:70)]
        public string Name { get; set; }
        public List<BookTag> BookTags { get; set; }
        public List<BlogTag> BlogTags { get; set; }
    }
}
