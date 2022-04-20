﻿using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [DataType(DataType.EmailAddress)]
        [StringLength(maximumLength: 60)]
        public string Email { get; set; }
    }
}
