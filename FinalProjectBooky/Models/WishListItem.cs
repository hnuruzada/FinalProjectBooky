﻿namespace FinalProjectBooky.Models
{
    public class WishListItem
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public string AppUserId { get; set; }
        public int Count { get; set; }
        public Book Book { get; set; }
        public AppUser AppUser { get; set; }
    }
}
