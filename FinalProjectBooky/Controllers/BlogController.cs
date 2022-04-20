using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using FinalProjectBooky.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBooky.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        public BlogController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            List<Blog> blogs = _context.Blogs.Include(b=>b.Publisher).Include(b=>b.Comments).Include(b=>b.Category).Include(b=>b.BlogTags).ThenInclude(bt=>bt.Tag).ToList();

            return View(blogs);
        }
        public IActionResult Detail(int id)
        {
            BlogDetailVM detailVM = new BlogDetailVM
            {
                Blog = _context.Blogs.Include(b => b.Comments).ThenInclude(b => b.AppUser).Include(b=>b.Publisher).FirstOrDefault(b => b.Id == id),
                Comments = _context.Comments.Include(c => c.Blog).Include(c => c.AppUser).Where(c => c.BlogId == id).ToList(),
            };
            ViewBag.Categories=_context.Categories.Include(c=>c.Blogs).ToList();
            ViewBag.Tags = _context.Tags.Include(t => t.BlogTags).ThenInclude(bt => bt.Blog).ToList();
            ViewBag.Blogs=_context.Blogs.Include(b=>b.BlogTags).ThenInclude(bt=>bt.Tag).Include(b=>b.Category).Include(b=>b.Publisher).Include(b=>b.Comments).ToList();
            return View(detailVM);
        }
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
            if (!_context.Blogs.Any(f => f.Id == comment.BlogId)) return NotFound();
            Comment cmnt = new Comment
            {
                Message = comment.Message,

                BlogId = comment.BlogId,
                Date = DateTime.Now,
                AppUserId = user.Id,
                IsAccess = true,
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
        }
     
        public async Task<IActionResult> DeleteComment(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Index", "Blog");
            if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Blog", new { id = comment.BlogId });
        }
        public IActionResult CategoryBlog(int Id)
        {
            List<Blog> blogs = _context.Blogs.Include(b => b.Publisher).Include(b => b.Category).Include(b => b.BlogTags).ThenInclude(bt => bt.Tag).Include(b=>b.Comments).Where(c => c.CategoryId == Id).ToList();
            ViewBag.Categories = _context.Categories.Include(c => c.Blogs).ToList();
            ViewBag.Tags = _context.Tags.Include(t => t.BlogTags).ThenInclude(bt => bt.Blog).ToList();
            ViewBag.Blogs = _context.Blogs.Include(b => b.BlogTags).ThenInclude(bt => bt.Tag).Include(b => b.Category).Include(b => b.Publisher).Include(b=>b.Comments).ToList();
            return View(blogs);
        }
        public IActionResult TagBlog(int id)
        {
            List<Blog> blogs = _context.Blogs.Include(b => b.Publisher).Include(b => b.Category).Include(b => b.BlogTags).ThenInclude(bt => bt.Tag).Include(b=>b.Comments).Where(c => c.BlogTags.Any(bt=>bt.TagId==id)).ToList();
            ViewBag.Categories = _context.Categories.Include(c => c.Blogs).ToList();
            ViewBag.Tags = _context.Tags.Include(t => t.BlogTags).ThenInclude(bt => bt.Blog).ToList();
            ViewBag.Blogs = _context.Blogs.Include(b=>b.Comments).Include(b => b.BlogTags).ThenInclude(bt => bt.Tag).Include(b => b.Category).Include(b => b.Publisher).Where(b=>b.Id==id).ToList();
            return View(blogs);
        }
    }
}
