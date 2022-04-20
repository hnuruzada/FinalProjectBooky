using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using FinalProjectBooky.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
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
                Blogs=_context.Blogs.Include(bl=>bl.Category).Include(bl=>bl.BlogTags).ThenInclude(bt=>bt.Tag).Include(b=>b.Publisher).ToList(),
                IconContainers=_context.IconContainers.ToList(),
            };
            return View(homeVM);
        }
        [HttpPost]
        public JsonResult Search(string search)
        {
            List<Book> books=_context.Books.Where(b=>b.Name.ToLower().Trim().Contains(search.ToLower().Trim())).ToList();
          
            return Json(books);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(SubscribeVM subscribeVM)
        {
            HomeVM homeVM = new HomeVM()
            {
                Books = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Campaign).ToList(),
                Settings = _context.Settings.Include(s => s.FooterSocialMedias).ToList(),
                Blogs = _context.Blogs.Include(bl => bl.Category).Include(bl => bl.BlogTags).ThenInclude(bt => bt.Tag).Include(b => b.Publisher).ToList(),
                IconContainers = _context.IconContainers.ToList(),
            };

            if (!ModelState.IsValid) return View();
            Subscribe emailCheck = _context.Subscribes.FirstOrDefault(s => s.Email == subscribeVM.Email);
            if (emailCheck != null)
            {
                ModelState.AddModelError("", "This email address is already subscriber,please enter different email address");
                return View(homeVM);
            }
            Subscribe subscribe = new Subscribe
            {
                Email = subscribeVM.Email,
            };


            string link = "https://localhost:44352/home/index";
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hasanng@code.edu.az", "Booky");
            mail.To.Add(new MailAddress(subscribe.Email));


            mail.Subject = "Subscribe email verification";
            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/Assets/Template/subscribe.html"))
            {
                body = reader.ReadToEnd();
            }

           
            body = body.Replace("{{link}}", link);
            mail.Body = body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;

            smtp.Credentials = new NetworkCredential("hasanng@code.edu.az", "Hasan0557578407");
            smtp.Send(mail);
            _context.Subscribes.Add(subscribe);
            _context.SaveChanges();

            return RedirectToAction("index", "home");
        }

    }
}
