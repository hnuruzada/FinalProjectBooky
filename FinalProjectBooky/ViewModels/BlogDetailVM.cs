using FinalProjectBooky.Models;
using System.Collections.Generic;

namespace FinalProjectBooky.ViewModels
{
    public class BlogDetailVM
    {
        public Blog Blog { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
