using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using FinalProjectBooky.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBooky.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Books = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab=>ab.Author).Include(b=>b.Campaign).ToList(),
                Settings=_context.Settings.Include(s => s.FooterSocialMedias).ToList(),
                Blogs=_context.Blogs.Include(bl=>bl.Category).Include(bl=>bl.BlogTags).ThenInclude(bt=>bt.Tag).ToList(),
                IconContainers=_context.IconContainers.ToList(),
            };
            return View(homeVM);
        }

        
    }
}
