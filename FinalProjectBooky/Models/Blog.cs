using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectBooky.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:150)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 1500)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public string Image { get; set; }
        public List<BlogTag> BlogTags { get; set; }
        public int CategoryId { get; set; }
        public Category Category  { get; set; }


        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public List<int> TagIds { get; set; }
    }
}
