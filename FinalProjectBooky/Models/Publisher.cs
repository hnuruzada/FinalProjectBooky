using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectBooky.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        [Required]

        [StringLength(maximumLength:30)]
        public string Name { get; set; }
        [Required]

        [StringLength(maximumLength: 30)]
        public string Surname { get; set; }
        [Required]

        [StringLength(maximumLength: 500)]
        public string Resume { get; set; }
        public string Image { get; set; }
        public List<Blog> Blogs { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
    }
}
