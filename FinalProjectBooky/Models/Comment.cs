using System;
using System.ComponentModel.DataAnnotations;

namespace FinalProjectBooky.Models
{
    public class Comment
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 200)]
        public string Message { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public bool IsAccess { get; set; }

        public int? BlogId { get; set; }
        public Blog Blog { get; set; }
        public int? BookId { get; set; }
        public Book Book { get; set; }
        public string AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
