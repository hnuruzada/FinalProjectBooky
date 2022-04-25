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
           
            List<Book> model = _context.Books.Include(b=>b.AuthorBooks).ThenInclude(ab=>ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt=>bt.Tag).ToList();
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
                    model = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderByDescending(s => s.CampaignId == null ? s.Price : (s.Price * (100 - s.Campaign.DiscountPercent) / 100)).ToList();
                    break;
                case 5:
                    model = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(f => f.BookCategories).ThenInclude(fc => fc.Category).Include(f => f.Campaign).Include(f => f.BookTags).ThenInclude(bt => bt.Tag).OrderBy(s => s.CampaignId == null ? s.Price : (s.Price * (100 - s.Campaign.DiscountPercent) / 100)).ToList(); 
                    break;
                default:
                    
                    break;
            }


            return View(model);
        }   
      
       

        public IActionResult Detail(int id,int categoryId)
        {

            Book book = _context.Books.Include(b=>b.Comments).Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(b=>b.Contents).Include(b => b.Campaign).FirstOrDefault(b => b.Id == id);
            if (book == null)
            {
                return NotFound();
            }
            ViewBag.Authors = _context.Authors.Include(a => a.AuthorBooks).ThenInclude(ab => ab.Book).Where(b => b.AuthorBooks.Any(b => b.BookId == id)).ToList();
            


            List<Category> categories=_context.Categories.Include(c=>c.BookCategories).ThenInclude(bc=>bc.Book).ThenInclude(bcb=>bcb.Comments).Where(b=>b.BookCategories.Any(bc=>bc.BookId==id)).ToList();

            List<Book> relatedBooks=new List<Book>();

            foreach (var item in categories)
            {
                relatedBooks = _context.Books.Include(b=>b.Comments).Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Campaign).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Where(b => b.BookCategories.Any(bc => bc.CategoryId == item.Id)).Skip(1).Take(4).ToList();
            }

            BookDetailVM bookDetailVM = new BookDetailVM()
            {
                Comments = _context.Comments.Include(c => c.Book).Include(c => c.AppUser).Where(c => c.BookId == id).ToList(),
                RelatedBooks = relatedBooks,
                Categories = categories,
                Book = book,
            };

            return View(bookDetailVM);

        }


        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> AddComment(Comment comment)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Detail", "Book", new { id = comment.BookId });
            if (!_context.Books.Any(f => f.Id == comment.BookId)) return NotFound();
            Comment cmnt = new Comment
            {
                Message = comment.Message,
                BookId = comment.BookId,
                Date = DateTime.Now,
                AppUserId = user.Id,
                IsAccess = true
            };
            _context.Comments.Add(cmnt);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Book", new { id = comment.BookId });
        }
       
        public async Task<IActionResult> DeleteComment(int id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (!ModelState.IsValid) return RedirectToAction("Detail", "Book");
            if (!_context.Comments.Any(c => c.Id == id && c.IsAccess == true && c.AppUserId == user.Id)) return NotFound();
            Comment comment = _context.Comments.FirstOrDefault(c => c.Id == id && c.AppUserId == user.Id);
            _context.Comments.Remove(comment);
            _context.SaveChanges();
            return RedirectToAction("Detail", "Book", new { id = comment.BookId });
        }
        [HttpPost]
        public async Task<IActionResult> increaseBookDetail(int Id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            BasketItem basket = _context.BasketItems.Include(b => b.Book).ThenInclude(b => b.Campaign).FirstOrDefault(b => b.BookId == Id && b.AppUserId == user.Id);
            basket.Count++;
            _context.SaveChanges();
            double TotalPrice = 0;
            double Price = basket.Count * (basket.Book.CampaignId == null ? basket.Book.Price : basket.Book.Price * (100 - basket.Book.Campaign.DiscountPercent) / 100);
            
             Book book = _context.Books.Include(b => b.Campaign).FirstOrDefault(b => b.Id == basket.BookId);

                BasketItemVM basketItemVM = new BasketItemVM
                {
                    Book = book,
                    Count = basket.Count
                };
                basketItemVM.Price = book.CampaignId == null ? book.Price : book.Price * (100 - book.Campaign.DiscountPercent) / 100;

                TotalPrice += basketItemVM.Price * basketItemVM.Count;

            

            return Json(new { totalPrice = TotalPrice, Price });
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
        [HttpPost]
        public async Task<IActionResult> increase(int Id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            BasketItem basket = _context.BasketItems.Include(b=>b.Book).ThenInclude(b=>b.Campaign).FirstOrDefault(b=>b.BookId==Id&&b.AppUserId==user.Id);
            basket.Count++;
            _context.SaveChanges();
            double TotalPrice = 0;
            double Price = basket.Count * (basket.Book.CampaignId == null ? basket.Book.Price : basket.Book.Price * (100 - basket.Book.Campaign.DiscountPercent) / 100);
            List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Include(b=>b.Book).Where(b => b.AppUserId == user.Id).ToList();
                foreach (BasketItem item in basketItems)
                {
                      Book book = _context.Books.Include(b=>b.Campaign).FirstOrDefault(b=>b.Id==item.BookId);
                    
                        BasketItemVM basketItemVM = new BasketItemVM
                        {
                            Book = book,
                            Count = item.Count
                        };
                        basketItemVM.Price = book.CampaignId == null ? book.Price : book.Price * (100 - book.Campaign.DiscountPercent) / 100;
                         
                        TotalPrice += basketItemVM.Price * basketItemVM.Count;
                    
                }
            
            return Json(new { totalPrice = TotalPrice ,Price});
        }
        public async Task<IActionResult> decrease(int Id)
        {
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
            BasketItem basket = _context.BasketItems.Include(b => b.Book).ThenInclude(b => b.Campaign).FirstOrDefault(b => b.BookId == Id && b.AppUserId == user.Id);
            if (basket.Count == 1)
            {
                basket.Count = 1;
            }
            else
            {
                basket.Count--;
            }
            _context.SaveChanges();
            double TotalPrice = 0;
            double Price = basket.Count * (basket.Book.CampaignId == null ? basket.Book.Price : basket.Book.Price * (100 - basket.Book.Campaign.DiscountPercent) / 100);
            List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Include(b => b.Book).Where(b => b.AppUserId == user.Id).ToList();
            foreach (BasketItem item in basketItems)
            {
                Book book = _context.Books.Include(b => b.Campaign).FirstOrDefault(b => b.Id == item.BookId);

                BasketItemVM basketItemVM = new BasketItemVM
                {
                    Book = book,
                    Count = item.Count
                };
                basketItemVM.Price = book.CampaignId == null ? book.Price : book.Price * (100 - book.Campaign.DiscountPercent) / 100;

                TotalPrice += basketItemVM.Price * basketItemVM.Count;

            }

            return Json(new { totalPrice = TotalPrice, Price });
        }
        public async Task<IActionResult> removeCartItem(int Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                List<BasketItem> basketItems = _context.BasketItems.Where(b => b.BookId == Id && b.AppUserId == user.Id).ToList();
                if (basketItems == null) return Json(new { status = 404 });
                foreach (var item in basketItems)
                {

                    _context.BasketItems.Remove(item);
                }
            }
           
            _context.SaveChanges();
            

            return Json(new { status = 200 });
        }

        public async Task<IActionResult> removeAll(int Id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                List<BasketItem> basketItems = _context.BasketItems.Where(b =>b.AppUserId == user.Id).ToList();
                if (basketItems == null) return Json(new { status = 404 });
                foreach (var item in basketItems)
                {

                    _context.BasketItems.Remove(item);
                }
            }

            _context.SaveChanges();


            return Json(new { status = 200 });
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

        public async Task<IActionResult> AddWishlist(int id)
        {
            Book book = _context.Books.Include(p => p.Campaign).Include(b=>b.AuthorBooks).ThenInclude(ab=>ab.Author).FirstOrDefault(p => p.Id == id);

            if (User.Identity.IsAuthenticated && User.IsInRole("Member"))
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

                WishListItem wishlistItem = _context.WishListItems.FirstOrDefault(b => b.BookId == book.Id && b.AppUserId == user.Id);
                if (wishlistItem == null)
                {
                    wishlistItem = new WishListItem
                    {
                        AppUserId = user.Id,
                        BookId = book.Id,
                       Count = 1,
                    };
                    _context.WishListItems.Add(wishlistItem);
                }
                else
                {
                    wishlistItem.Count=1;
                }
                _context.SaveChanges();
                return PartialView("_WishlistPartialView");
            }
            else
            {
                string wishlist = HttpContext.Request.Cookies["Wishlist"];

                if (wishlist == null)
                {
                    List<WishListCookieItemVM> wishlistCookieItems = new List<WishListCookieItemVM>();

                    wishlistCookieItems.Add(new WishListCookieItemVM
                    {
                        Id = book.Id,
                        Count = 1
                    });

                    string wishlistStr = JsonConvert.SerializeObject(wishlistCookieItems);

                    HttpContext.Response.Cookies.Append("Wishlist", wishlistStr);
                    return PartialView("_WishlistPartialView");

                }
                else
                {
                    List<WishListCookieItemVM> wishlistCookieItems = JsonConvert.DeserializeObject<List<WishListCookieItemVM>>(wishlist);

                    WishListCookieItemVM cookieItem = wishlistCookieItems.FirstOrDefault(b => b.Id == book.Id);

                    if (cookieItem == null)
                    {
                        cookieItem = new WishListCookieItemVM
                        {
                            Id = book.Id,
                            Count = 1
                        };
                        wishlistCookieItems.Add(cookieItem);
                    }
                    else
                    {
                        cookieItem.Count=1;
                    }

                    string wishlistStr = JsonConvert.SerializeObject(wishlistCookieItems);

                    HttpContext.Response.Cookies.Append("Wishlist", wishlistStr);

                    return PartialView("_WishlistPartialView");
                }
            }
        }

        public IActionResult GetWishlistPartial()
        {
            return PartialView("_WishlistPartialView");
        }

        public async Task<IActionResult> DeleteWishListItem(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                List<WishListItem> wishlistItems = _context.WishListItems.Where(b => b.BookId == id && b.AppUserId == user.Id).ToList();
                foreach (var item in wishlistItems)
                {
                    _context.WishListItems.Remove(item);
                }
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Wishlist"];

                List<WishListCookieItemVM> wishlistCookieItems = JsonConvert.DeserializeObject<List<WishListCookieItemVM>>(basket);

                WishListCookieItemVM cookieItem = wishlistCookieItems.FirstOrDefault(c => c.Id == id);


                wishlistCookieItems.Remove(cookieItem);

                string wishlistStr = JsonConvert.SerializeObject(wishlistCookieItems);

                HttpContext.Response.Cookies.Append("Wishlist", wishlistStr);

            }
            _context.SaveChanges();
            return PartialView("_WishlistPartialView");
        }
        public async Task<IActionResult> DeleteAllWishList(int id)
        {
            if (User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);
                List<WishListItem> wishlistItems = _context.WishListItems.Where(b=> b.AppUserId == user.Id).ToList();
                foreach (var item in wishlistItems)
                {
                    _context.WishListItems.Remove(item);
                }
            }
            else
            {
                string basket = HttpContext.Request.Cookies["Wishlist"];

                List<WishListCookieItemVM> wishlistCookieItems = JsonConvert.DeserializeObject<List<WishListCookieItemVM>>(basket);

                wishlistCookieItems.Clear();
             
                string wishlistStr = JsonConvert.SerializeObject(wishlistCookieItems);
                HttpContext.Response.Cookies.Append("Wishlist", wishlistStr);

            }
            _context.SaveChanges();
            return PartialView("_WishlistPartialView");
        }
    }
}
