using FinalProjectBooky.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.ViewModels
{
    public class OrderVM
    {
        [Required]
        [StringLength(maximumLength: 30)]
        public string Name { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string Surname { get; set; }
        [Required]
        [StringLength(maximumLength: 25)]
        public string Username { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(maximumLength: 150)]
        public string Address { get; set; }
        [Required]
        [StringLength(maximumLength: 40)]
        public string Country { get; set; }
        [Required]
        [StringLength(maximumLength: 30)]
        public string State { get; set; }
        public List<BasketItem> BasketItems { get; set; }
    }
}
