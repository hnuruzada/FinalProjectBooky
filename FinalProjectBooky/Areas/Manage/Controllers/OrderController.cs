using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class OrderController : Controller
    {
        private readonly AppDbContext _context;

        public OrderController(AppDbContext context)
        {
            _context = context;
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

        public IActionResult Accept(int id, string message)
        {

            Order order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return Json(new { status = 400 });
            order.Status = true;
            order.Message = message;
            _context.SaveChanges();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hasanng@code.edu.az", "Booky");
            mail.To.Add(new MailAddress("h.nuruzade@gmail.com"));

            mail.Subject = "Order";
            mail.Body = $"{message}";
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new NetworkCredential("hasanng@code.edu.az", "Hasan0557578407");
            smtp.Send(mail);
            return Json(new { status = 200 });
        }
        public IActionResult Reject(int id, string message)
        {

            Order order = _context.Orders.FirstOrDefault(o => o.Id == id);
            if (order == null) return Json(new { status = 400 });
            order.Status = false;
            order.Message = message;
            _context.SaveChanges();
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("hasanng@code.edu.az", "Booky");
            mail.To.Add(new MailAddress("h.nuruzade@gmail.com"));

            mail.Subject = "Order";
            mail.Body = $"{message}";
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
