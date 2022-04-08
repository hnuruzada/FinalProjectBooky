using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]


    public class IconContainerController : Controller
    {
        private readonly AppDbContext _context;
        


        public IconContainerController(AppDbContext context)
        {
            _context = context;
           
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.IconContainers.Count() / 4);
            ViewBag.CurrentPage = page;
            List<IconContainer> iconContainers = _context.IconContainers.Skip((page - 1) * 4).Take(4).ToList();

            return View(iconContainers);
        }


        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(IconContainer iconContainer)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            _context.IconContainers.Add(iconContainer);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int id)
        {
           

            IconContainer iconContainer = _context.IconContainers.FirstOrDefault(b => b.Id == id);
            if (iconContainer == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(iconContainer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, IconContainer iconContainer)
        {
          

            IconContainer existIcon = _context.IconContainers.FirstOrDefault(x => x.Id == id);


            if (existIcon == null)
            {
                return RedirectToAction("index");
            }
            


            if (!ModelState.IsValid)
            {
                return View();
            }

            existIcon.Icon = iconContainer.Icon;
            existIcon.Title = iconContainer.Title;
            existIcon.Description = iconContainer.Description;
 
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {
            IconContainer iconContainer = _context.IconContainers.FirstOrDefault(c => c.Id == id);
            if (iconContainer == null) return Json(new { status = 404 });

           

            _context.IconContainers.Remove(iconContainer);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }
    }
}
