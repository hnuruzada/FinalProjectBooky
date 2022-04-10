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
    public class BookController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public BookController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Books.Count() / 2);
            ViewBag.CurrentPage = page;
            List<Book> books = _context.Books.Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(bl=>bl.Language).Include(b=>b.AuthorBooks).ThenInclude(ab=>ab.Author).Include(b=>b.Contents).Include(b=>b.Campaign).Skip((page - 1) * 2).Take(2).ToList();

            return View(books);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Languages = _context.Languages.ToList();
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Campaigns=_context.Campaigns.ToList();
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book book)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Languages = _context.Languages.ToList();
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Campaigns = _context.Campaigns.ToList();


            if (!ModelState.IsValid)
            {
                return View();
            }
            
            book.BookTags = new List<BookTag>();
            book.BookCategories = new List<BookCategory>();

           
            

            if (book.ImageFile != null)
            {
                if (!book.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct image format file");
                    return View();
                }
                if (!book.ImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                book.Image = book.ImageFile.SaveImg(_env.WebRootPath, "assets/images");
            }
            if (book.AuthorIds != null)
            {
                foreach (var authorId in book.AuthorIds)
                {
                    AuthorBook authorBook = new AuthorBook
                    {
                        Book = book,
                        AuthorId = authorId
                    };
                    _context.AuthorBooks.Add(authorBook);
                }
            }


            if (book.CategoryIds != null)
            {
                foreach (var categoryId in book.CategoryIds)
                {
                    BookCategory bookCategory = new BookCategory
                    {
                        Book = book,
                        CategoryId = categoryId
                    };
                    _context.BookCategories.Add(bookCategory);
                }
            }
            if (book.TagIds != null)
            {
                foreach (var tagId in book.TagIds)
                {
                    BookTag bookTag = new BookTag
                    {
                        Book = book,
                        TagId = tagId
                    };
                    _context.BookTags.Add(bookTag);
                }
            }
           

            _context.Books.Add(book);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Languages = _context.Languages.ToList();
            ViewBag.Authors = _context.Authors.Include(a=>a.AuthorBooks).ThenInclude(ab=>ab.Book).ToList();
            ViewBag.Campaigns = _context.Campaigns.ToList();
           
            Book book = _context.Books.Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(bl => bl.Language).Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Contents).Include(b => b.Campaign).FirstOrDefault(b=>b.Id==id);
            if (book == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit( Book book)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags = _context.Tags.ToList();
            ViewBag.Languages = _context.Languages.ToList();
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Campaigns = _context.Campaigns.ToList();

            Book existBook=_context.Books.Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(bl => bl.Language).Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Contents).Include(b => b.Campaign).FirstOrDefault(x => x.Id ==book.Id);
            
            
            
            if (existBook == null)
            {
                return RedirectToAction("index");
            }
            if (book.ImageFile != null)
            {
                if (!book.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View(existBook);
                }
                if (!book.ImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View(existBook);
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", existBook.Image);
                existBook.Image = book.ImageFile.SaveImg(_env.WebRootPath, "assets/images");


            }
           


            if (!ModelState.IsValid)
            {
                return View(existBook);
            }
            var existAuthors = _context.AuthorBooks.Where(x => x.BookId == book.Id).ToList();
            if (book.AuthorIds != null)
            {
                foreach (var authorId in book.AuthorIds)
                {
                    var existAuthor = existAuthors.FirstOrDefault(x => x.AuthorId == authorId);
                    if (existAuthor == null)
                    {
                        AuthorBook authorBook = new AuthorBook
                        {
                            BookId = book.Id,
                            AuthorId = authorId,
                        };

                        _context.AuthorBooks.Add(authorBook);
                    }
                    else
                    {
                        existAuthors.Remove(existAuthor);
                    }
                }

            }
            _context.AuthorBooks.RemoveRange(existAuthors);

            var existTags = _context.BookTags.Where(x => x.BookId == book.Id).ToList();
            if (book.TagIds != null)
            {
                foreach (var tagId in book.TagIds)
                {
                    var existTag = existTags.FirstOrDefault(x => x.TagId == tagId);
                    if (existTag == null)
                    {
                        BookTag bookTag = new BookTag
                        {
                            BookId = book.Id,
                            TagId = tagId,
                        };

                        _context.BookTags.Add(bookTag);
                    }
                    else
                    {
                        existTags.Remove(existTag);
                    }
                }

            }
            _context.BookTags.RemoveRange(existTags);

            var existCategories = _context.BookCategories.Where(x => x.BookId == book.Id).ToList();
            if (book.CategoryIds != null)
            {
                foreach (var categoryId in book.CategoryIds)
                {
                    var existCategory = existCategories.FirstOrDefault(x => x.CategoryId == categoryId);
                    if (existCategory == null)
                    {
                        BookCategory bookCategory = new BookCategory
                        {
                            BookId = book.Id,
                            CategoryId = categoryId,
                        };

                        _context.BookCategories.Add(bookCategory);
                    }
                    else
                    {
                        existCategories.Remove(existCategory);
                    }
                }

            }
            _context.BookCategories.RemoveRange(existCategories);

           

            List<Content> existContent= _context.Contents.Where(x => x.BookId == book.Id).ToList();


            List<Content> content = book.Contents;
            if (content != null)
            {
                _context.Books.FirstOrDefault(x => x.Id == book.Id).Contents = content;
            }
            if (existContent != null)
            {
                _context.Contents.RemoveRange(existContent);
            }

            existBook.Name = book.Name;
            existBook.PageCount = book.PageCount;
            existBook.Date = book.Date;
            existBook.Price = book.Price;
            existBook.Summary = book.Summary;
            existBook.LeftSideColor = book.LeftSideColor;
            existBook.BackSideColor = book.BackSideColor;
            existBook.SkuCode= book.SkuCode;
            existBook.InStock= book.InStock;
            existBook.CampaignId = book.CampaignId;
            existBook.LanguageId = book.LanguageId;
            existBook.Contents=book.Contents;
           
           
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {

            Book book = _context.Books.Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(bl => bl.Language).Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Contents).Include(b => b.Campaign).FirstOrDefault(b => b.Id == id);
            Book existBook = _context.Books.Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(bl => bl.Language).Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Contents).Include(b => b.Campaign).FirstOrDefault(s => s.Id == book.Id);

            if (existBook == null) return NotFound();
            if (book == null) return Json(new { status = 404 });

            Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", existBook.Image);

            _context.Books.Remove(book);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }

    }
}
