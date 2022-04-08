using FinalProjectBooky.DAL;
using FinalProjectBooky.Extensions;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]

    
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;


        public BlogController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;

        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Blogs.Count() / 2);
            ViewBag.CurrentPage = page;
            List<Blog> blogs = _context.Blogs.Include(f => f.Category).Include(c => c.BlogTags).ThenInclude(ct => ct.Tag).Skip((page - 1) * 2).Take(2).ToList();

            return View(blogs);
        }


        public IActionResult Create()
        {
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blog blog)
        {
            ViewBag.Categories = _context.Categories.ToList();

            ViewBag.Tags = _context.Tags.ToList();

            if (!_context.Categories.Any(x => x.Id == blog.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Xetaniz var!");
                return View();
            }
            

            if (!ModelState.IsValid)
            {
                return View();
            }
            blog.BlogTags = new List<BlogTag>();
            if (blog.ImageFile != null)
            {
                if (!blog.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct image format file");
                    return View();
                }
                if (!blog.ImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                blog.Image = blog.ImageFile.SaveImg(_env.WebRootPath, "assets/images");
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Choose Image for Blog");
                return View();
            }



            if (blog.TagIds != null)
            {
                foreach (var tagId in blog.TagIds)
                {
                    BlogTag blogTag = new BlogTag
                    {
                        Blog = blog,
                        TagId = tagId
                    };
                    _context.BlogTags.Add(blogTag);
                }
            }
            _context.Blogs.Add(blog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            Blog blog = _context.Blogs.Include(b=>b.Category).Include(x => x.BlogTags).ThenInclude(bt=>bt.Tag).FirstOrDefault(x => x.Id ==id);
            if (blog == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Blog blog)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();

            Blog existBlog = _context.Blogs.Include(b=>b.Category).Include(b=>b.BlogTags).ThenInclude(bt=>bt.Tag).FirstOrDefault(x => x.Id == id);
            if (!_context.Categories.Any(x => x.Id == blog.CategoryId)) return RedirectToAction(nameof(Index));
            if (existBlog == null)
            {
                return RedirectToAction("index");
            }
            if (blog.ImageFile != null)
            {
                if (!blog.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!blog.ImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", existBlog.Image);
                existBlog.Image = blog.ImageFile.SaveImg(_env.WebRootPath, "assets/images");


            }


            if (!ModelState.IsValid)
            {
                return View();
            }

            var existTags = _context.BlogTags.Where(x => x.BlogId == id).ToList();
            if (blog.TagIds != null)
            {
                foreach (var tagId in blog.TagIds)
                {
                    var existTag = existTags.FirstOrDefault(x => x.TagId == tagId);
                    if (existTag == null)
                    {
                        BlogTag blogTag = new BlogTag
                        {
                            BlogId = id,
                            TagId = tagId,
                        };

                        _context.BlogTags.Add(blogTag);
                    }
                    else
                    {
                        existTags.Remove(existTag);
                    }
                }

            }
           
            _context.BlogTags.RemoveRange(existTags);



            existBlog.Title= blog.Title;
            existBlog.Description = blog.Description;
            existBlog.Date = blog.Date;
            existBlog.CategoryId= blog.CategoryId;
            
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {
            Blog blog = _context.Blogs.FirstOrDefault(c => c.Id == id);
            if (blog == null) return Json(new { status = 404 });

            Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", blog.Image);

            _context.Blogs.Remove(blog);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }

        //public IActionResult Comments(int courseId)
        //{
        //    if (!_context.Comments.Any(c => c.CourseId == courseId)) return RedirectToAction("Index", "Course");

        //    List<Comment> comments = _context.Comments.Include(c => c.Course).Include(c => c.AppUser).Where(c => c.CourseId == courseId).ToList();



        //    return View(comments);
        //}

        //public IActionResult CommentStatusChange(int id)
        //{
        //    if (!_context.Comments.Any(c => c.Id == id)) return RedirectToAction("Index", "Course");
        //    Comment comment = _context.Comments.SingleOrDefault(c => c.Id == id);

        //    comment.IsAccess = comment.IsAccess ? false : true;
        //    _context.SaveChanges();
        //    return RedirectToAction("Comments", "Course", new { CourseId = comment.CourseId });
        //}

    }
}
