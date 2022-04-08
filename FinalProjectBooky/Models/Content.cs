using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class Content
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string PartOf { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [Required]
        
        public int PageNumber { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
