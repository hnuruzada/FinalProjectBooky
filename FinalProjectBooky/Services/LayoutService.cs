using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using FinalProjectBooky.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectBooky.Services
{
    [Authorize(Roles = "Member")]
    public class LayoutService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _httpContext;
        private readonly UserManager<AppUser> _userManager;

        public LayoutService(AppDbContext context, IHttpContextAccessor httpContextAccessor, UserManager<AppUser> userManager)
        {
            _context = context;
            _httpContext = httpContextAccessor;
            _userManager = userManager;
        }

        public Setting GetSettingData()
        {
            Setting data = _context.Settings.Include(s => s.FooterSocialMedias).FirstOrDefault();
            return data;
        }
        public async Task<BasketVM> ShowBasket()
        {
            string basket = _httpContext.HttpContext.Request.Cookies["Basket"];

            BasketVM basketData = new BasketVM
            {
                TotalPrice = 0,
                BasketItems = new List<BasketItemVM>(),
                Count = 0
            };
            if (_httpContext.HttpContext.User.Identity.IsAuthenticated)
            {
                AppUser user = await _userManager.FindByNameAsync(_httpContext.HttpContext.User.Identity.Name);
                List<BasketItem> basketItems = _context.BasketItems.Include(b => b.AppUser).Where(b => b.AppUserId == user.Id).ToList();
                foreach (BasketItem item in basketItems)
                {
                    Book book = _context.Books.Include(f => f.Campaign).Include(f => f.AuthorBooks).ThenInclude(ab => ab.Author).FirstOrDefault(f => f.Id == item.BookId);
                    if (book != null)
                    {
                        BasketItemVM basketItemVM = new BasketItemVM
                        {
                            Book = book,
                            Count = item.Count
                        };
                        basketItemVM.Price = book.CampaignId == null ? book.Price : book.Price * (100 - book.Campaign.DiscountPercent) / 100;
                        basketData.BasketItems.Add(basketItemVM);
                        basketData.Count++;
                        basketData.TotalPrice += basketItemVM.Price * basketItemVM.Count;
                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(basket))
                {
                    List<BasketCookieItemVM> basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                    foreach (BasketCookieItemVM item in basketCookieItems)
                    {
                        Book book = _context.Books.FirstOrDefault(f => f.Id == item.Id);
                        if (book != null)
                        {
                            BasketItemVM basketItem = new BasketItemVM
                            {
                                Book = _context.Books.Include(f => f.Campaign).Include(f => f.AuthorBooks).ThenInclude(ab=>ab.Author).FirstOrDefault(f => f.Id == item.Id),
                                Count = item.Count

                            };
                            basketItem.Price = basketItem.Book.CampaignId == null ? basketItem.Book.Price : basketItem.Book.Price * (100 - basketItem.Book.Campaign.DiscountPercent) / 100;
                            basketData.BasketItems.Add(basketItem);
                            basketData.Count++;
                            basketData.TotalPrice += basketItem.Price * basketItem.Count;
                        }
                    }

                }
            }

            return basketData;

        }
    }
}
