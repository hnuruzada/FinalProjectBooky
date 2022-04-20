using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public OrderController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index(int page=1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Orders.Count() / 6);
            ViewBag.CurrentPage = page;
            List<Order> orders = _context.Orders.Skip((page - 1) * 6).Take(6).ToList();
            return View(orders);
        }

        public IActionResult Edit(int id)
        {
            Order order = _context.Orders.Include(o => o.OrderItems).Include(o => o.AppUser).FirstOrDefault(o => o.Id == id);
            if (order == null) return NotFound();
            return View(order);
        }

        public async Task<IActionResult> Accept(int id, string message)
        {
            Order order = _context.Orders.FirstOrDefault(o => o.Id == id);
            AppUser user = await _userManager.FindByIdAsync(order.AppUserId);
            if (order == null) return Json(new { status = 400 });
            order.Status = true;
            order.Message = message;
            _context.SaveChanges();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hasanng@code.edu.az", "Booky");
            mail.To.Add(new MailAddress(user.Email));

            mail.Subject = "Order";

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/Assets/Template/OrderMessage.html"))
            {
                body = reader.ReadToEnd();
            }
            string aboutText = $"Hello Mr/Mrs <strong>{user.Name + " " + user.Surname}</strong>";
            string messageTxt = $"{message}";
            body = body.Replace("{{message}}", messageTxt);
            mail.Body = body.Replace("{{aboutText}}", aboutText);
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("hasanng@code.edu.az", "Hasan0557578407");
            smtp.Send(mail);
            return Json(new { status = 200 });
        }
        public async Task<IActionResult> Reject(int id, string message)
        {
            Order order = _context.Orders.FirstOrDefault(o => o.Id == id);
            AppUser user = await _userManager.FindByIdAsync(order.AppUserId);
            if (order == null) return Json(new { status = 400 });
            order.Status = false;
            order.Message = message;
            _context.SaveChanges();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hasanng@code.edu.az", "Booky");
            mail.To.Add(new MailAddress(user.Email));

            mail.Subject = "Order";

            string body = string.Empty;

            using (StreamReader reader = new StreamReader("wwwroot/assets/template/OrderMessage.html"))
            {
                body = reader.ReadToEnd();
            }
            string aboutText = $"Hello Mr/Mrs <strong>{user.Name + " " + user.Surname}</strong>";
            string messageTxt = $"{message}";
            body = body.Replace("{{message}}", messageTxt);
            mail.Body = body.Replace("{{aboutText}}", aboutText);
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("hasanng@code.edu.az", "Hasan0557578407");
            smtp.Send(mail);
            return Json(new { status = 200 });
        }

    }
}
