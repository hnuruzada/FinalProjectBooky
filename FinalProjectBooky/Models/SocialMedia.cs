using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class SocialMedia
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Icon { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Url { get; set; }
       
    }
}
