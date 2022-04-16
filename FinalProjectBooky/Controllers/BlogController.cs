using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectBooky.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(b=>b.Publisher).Include(b=>b.Category).Include(b=>b.BlogTags).ThenInclude(bt=>bt.Tag).ToList();

            return View(blogs);
        }
        public IActionResult Detail(int id)
        {
            Blog blog=_context.Blogs.Include(b=>b.Publisher).FirstOrDefault(b=>b.Id== id);
            ViewBag.Categories=_context.Categories.Include(c=>c.Blogs).ToList();
            ViewBag.Tags = _context.Tags.Include(t => t.BlogTags).ThenInclude(bt => bt.Blog).ToList();
            ViewBag.Blogs=_context.Blogs.Include(b=>b.BlogTags).ThenInclude(bt=>bt.Tag).Include(b=>b.Category).Include(b=>b.Publisher).ToList();
            return View(blog);
        }

        public IActionResult CategoryBlog(int Id)
        {
            List<Blog> blogs = _context.Blogs.Include(b => b.Publisher).Include(b => b.Category).Include(b => b.BlogTags).ThenInclude(bt => bt.Tag).Where(c => c.CategoryId == Id).ToList();
            ViewBag.Categories = _context.Categories.Include(c => c.Blogs).ToList();
            ViewBag.Tags = _context.Tags.Include(t => t.BlogTags).ThenInclude(bt => bt.Blog).ToList();
            ViewBag.Blogs = _context.Blogs.Include(b => b.BlogTags).ThenInclude(bt => bt.Tag).Include(b => b.Category).Include(b => b.Publisher).ToList();
            return View(blogs);
        }
        public IActionResult TagBlog(int id)
        {
            List<Blog> blogs = _context.Blogs.Include(b => b.Publisher).Include(b => b.Category).Include(b => b.BlogTags).ThenInclude(bt => bt.Tag).Where(c => c.BlogTags.Any(bt=>bt.TagId==id)).ToList();
            ViewBag.Categories = _context.Categories.Include(c => c.Blogs).ToList();
            ViewBag.Tags = _context.Tags.Include(t => t.BlogTags).ThenInclude(bt => bt.Blog).ToList();
            ViewBag.Blogs = _context.Blogs.Include(b => b.BlogTags).ThenInclude(bt => bt.Tag).Include(b => b.Category).Include(b => b.Publisher).Where(b=>b.Id==id).ToList();
            return View(blogs);
        }
    }
}
