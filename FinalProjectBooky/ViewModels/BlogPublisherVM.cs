using FinalProjectBooky.Models;
using System.Collections.Generic;

namespace FinalProjectBooky.ViewModels
{
    public class BlogPublisherVM
    {
        public List<Blog> Blogs { get; set; }
        public List<Publisher> Publishers { get; set; }
        public List<Category> Categories { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
