using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FinalProjectBooky.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Name { get; set; }
        public string Image { get; set; }
        [Required]
        [StringLength(maximumLength: 500)]
        public string Summary { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]

        public decimal Price { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string LeftSideColor { get; set; }
        [Required]
        [StringLength(maximumLength: 20)]
        public string BackSideColor { get; set; }
        [Required]

        public int SkuCode { get; set; }
        public bool InStock { get; set; }
        [Required]
        
        public DateTime Date { get; set; }
        [Required]
        public int PageCount { get; set; }
        public List<Content> Contents { get; set; }
        public List<AuthorBook> AuthorBooks { get; set; }
       
        public List<BookCategory> BookCategories { get; set; }
        public List<BookTag> BookTags  { get; set; }
        public int? LanguageId { get; set; }
        public Language Language { get; set; }
        public int? CampaignId { get; set; }
        public Campaign Campaign { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        [NotMapped]
        public List<int> TagIds { get; set; }
        [NotMapped]
        public List<int> CategoryIds { get; set; }
        [NotMapped]
        public List<int> LanguageIds { get; set; }
        [NotMapped]
        public List<int> AuthorIds { get; set; }




    }
}
