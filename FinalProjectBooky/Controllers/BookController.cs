using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using FinalProjectBooky.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBooky.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BookController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index(int sortId,int page=1)
        {
            ViewBag.CurrentPage = page;
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Books.Count() / 4);
           
            List<Book> model = _context.Books.Include(b=>b.AuthorBooks).ThenInclude(ab=>ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt=>bt.Tag).Skip((page - 1) * 4).Take(4).ToList();
            ViewBag.Categories = _context.Categories.Include(c=>c.BookCategories).ThenInclude(bc=>bc.Book).ToList();
            ViewBag.Tags= _context.Tags.Include(b=>b.BookTags).ThenInclude(bt=>bt.Book).ToList();
            ViewBag.id = sortId;
           
            switch (sortId)
            {
                case 1:
                    model = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).ToList();
                    break;
                case 2:
                    model = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderByDescending(s => s.Name).ToList();
                    break;
                case 3:
                    model = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderBy(s => s.Name).ToList();
                    break;
                case 4:
                    model = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderByDescending(s => s.Price).ToList();
                    break;
                case 5:
                    model = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderBy(s => s.Price).ToList(); 
                    break;
                default:
                    
                    break;
            }


            return View(model);
        }   
      
       

        public IActionResult Detail(int id,int categoryId)
        {

            Book book = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(b => b.Campaign).FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            ViewBag.Authors = _context.Authors.Include(a => a.AuthorBooks).ThenInclude(ab => ab.Book).Where(b => b.AuthorBooks.Any(b => b.BookId == id)).ToList();
            ViewBag.Categories = _context.Categories.Include(b=>b.BookCategories).ThenInclude(bc=>bc.Book).Where(c => c.BookCategories.Any(c => c.BookId == id)).ToList();
            ViewBag.RelatedBooks = _context.Books.Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b=>b.AuthorBooks).ThenInclude(ab=>ab.Author).Include(b=>b.BookTags).ThenInclude(bt=>bt.Tag).Include(b=>b.Campaign).Where(b => b.BookCategories.Any(bc => bc.CategoryId == categoryId)).ToList();
            ViewBag.RelatedBppks=_context.Books.Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(b => b.Campaign).Where(b => b.BookCategories.Any(bc => bc.CategoryId == categoryId)).ToList();


            var items = _context.BookCategories.Include(n => n.Book).Where(b => b.CategoryId == categoryId);
           
            List<Book> relatedBooks = new List<Book>();

            foreach (var item in items)
            {
                relatedBooks = _context.Books.Where(n => n.Id == item.BookId).ToList();
            }

            BookDetailVM bookDetailVM = new BookDetailVM()
            {
                RelatedBooks = relatedBooks,
                Book = book,
            };


            return View(bookDetailVM);

        }
        public async Task<IActionResult> AddBasket(int id)
        {
            Book book = _context.Books.Include(f => f.Campaign).FirstOrDefault(f => f.Id == id);


            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                BasketItem basketItem = _context.BasketItems.FirstOrDefault(b => b.BookId == book.Id && b.AppUserId == user.Id);
                if (basketItem == null)
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        BookId = book.Id,
                        Count = 1
                    };
                    _context.BasketItems.Add(basketItem);
                }
                else
                {
                    basketItem.Count++;
                }
                _context.SaveChanges();

                return PartialView("_basketPartial");
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Basket"];

                if (basket == null)
                {
                    List<BasketCookieItemVM> basketCookieItems = new List<BasketCookieItemVM>();

                    basketCookieItems.Add(new BasketCookieItemVM
                    {
                        Id = book.Id,
                        Count = 1
                    });

                    string basketStr = JsonConvert.SerializeObject(basketCookieItems);


                    HttpContext.Response.Cookies.Append("Basket", basketStr);
                    return PartialView("_basketPartial");

                }
                else
                {
                    List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                    BasketCookieItemVM cookieItem = basketCookieItems.FirstOrDefault(c => c.Id == book.Id);

                    if (cookieItem == null)
                    {
                        cookieItem = new BasketCookieItemVM
                        {
                            Id = book.Id,
                            Count = 1
                        };
                        basketCookieItems.Add(cookieItem);
                    }
                    else
                    {
                        cookieItem.Count++;
                    }


                   
                    string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                    HttpContext.Response.Cookies.Append("Basket", basketStr);
                    return PartialView("_basketPartial");

                }
            }



            //return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> DeleteBasketitem(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                List<BasketItem> basketItems = _context.BasketItems.Where(b=>b.BookId==id&&b.AppUserId==user.Id).ToList();
                foreach (var item in basketItems)
                {

                _context.BasketItems.Remove(item);
                }
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Basket"];

                List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                BasketCookieItemVM cookieItem = basketCookieItems.FirstOrDefault(c => c.Id == id);

              
                    basketCookieItems.Remove(cookieItem);
                
                string basketStr = JsonConvert.SerializeObject(basketCookieItems);

                HttpContext.Response.Cookies.Append("Basket", basketStr);

            }
            _context.SaveChanges();
            return PartialView("_basketPartial");
        }
        public IActionResult GetPartial()
        {
            return PartialView("_basketPartial");
        }


       
        public IActionResult ShowBasket()
        {
          
            string basketStr = HttpContext.Request.Cookies["Basket"];
            if (!string.IsNullOrEmpty(basketStr))
            {
                List<BasketCookieItemVM> basket = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basketStr);
                return Json(basket);
            }
            return Content("Basket is empty");
        }

    }
}
