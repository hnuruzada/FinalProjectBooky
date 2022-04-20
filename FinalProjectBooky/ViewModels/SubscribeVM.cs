using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.ViewModels
{
    public class SubscribeVM
    {
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 60)]
        public string Email { get; set; }
    }
}
