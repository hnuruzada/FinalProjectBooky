using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class Setting
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Logo { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string WebName { get; set; }

        public string ParallaxImage { get; set; }

        public string FooterImage { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string PhoneNumber1 { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string PhoneNumber2 { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Email { get; set; }
        public List<FooterSocialMedia> FooterSocialMedias { get; set; }
    }
}
