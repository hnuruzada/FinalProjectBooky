using FinalProjectBooky.Models;
using System.Collections.Generic;

namespace FinalProjectBooky.ViewModels
{
    public class HomeVM
    {
        public List<Book> Books { get; set; }
        public List<Setting> Settings { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Author> Authors { get; set; }
        public List<IconContainer> IconContainers { get; set; }
        public SubscribeVM SubscribeVM { get; set; }
    }
}
