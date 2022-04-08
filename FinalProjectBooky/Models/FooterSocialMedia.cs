using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class FooterSocialMedia
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Icon { get; set; }
        [Required]
        [StringLength(maximumLength: 250)]
        public string Url { get; set; }
        public int SettingId { get; set; }
        public Setting Setting { get; set; }
    }
}
