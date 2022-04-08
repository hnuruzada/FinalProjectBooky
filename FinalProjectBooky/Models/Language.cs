using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class Language
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
