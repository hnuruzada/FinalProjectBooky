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
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Tags= _context.Tags.ToList();
            ViewBag.id = sortId;
           
            switch (sortId)
            {
                case 1:
                    model = _context.Books.ToList();
                    break;
                case 2:
                    model = _context.Books.OrderByDescending(s => s.Name).ToList();
                    break;
                case 3:
                    model = _context.Books.OrderBy(s => s.Name).ToList();
                    break;
                case 4:
                    model = _context.Books.OrderByDescending(s => s.Price).ToList();
                    break;
                case 5:
                    model = _context.Books.OrderBy(s => s.Price).ToList(); 
                    break;
                default:
                    
                    break;
            }


            return View(model);
        }   
        public IActionResult LowToHigh()
        {
            List<Book> book = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderBy(b => b.Price).ToList();
            return View(book); 
        }
        public IActionResult HighToLow()
        {
            List<Book> book1 = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderByDescending(b=>b.Price).ToList();
            return View(book1);
        }
        public IActionResult AFromZ()
        {
            List<Book> book2 = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderBy(b => b.Name).ToList();
            return View(book2);
        }
        public IActionResult ZFromA()
        {
            List<Book> book3 = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderByDescending(b => b.Name).ToList();
            return View(book3);
        }

        public IActionResult Detail()
        {
            return View();
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
