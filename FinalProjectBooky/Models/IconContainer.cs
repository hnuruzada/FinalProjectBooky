using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class IconContainer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Icon { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Description { get; set; }
    }
}
