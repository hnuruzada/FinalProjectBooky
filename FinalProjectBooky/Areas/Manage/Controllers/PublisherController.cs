using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using FinalProjectBooky.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Publisher")]
    public class PublisherController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public PublisherController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Publishers.Count() / 2);
            ViewBag.CurrentPage = page;
            List<Publisher> publisher = _context.Publishers.Include(f => f.Blogs).Skip((page - 1) * 2).Take(2).ToList();

            return View(publisher);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Publisher publisher)
        {

            List<Publisher> Names = _context.Publishers.Where(hs => (hs.Name.ToLower().Trim() + " " + hs.Surname.ToLower().Trim()).Contains(publisher.Name.ToLower().Trim() + " " + publisher.Surname.ToLower().Trim())).ToList();

            if (!ModelState.IsValid)
            {
                return View();
            }
            foreach (var item in Names)
            {
                if ((item.Name.ToLower().Trim() + " " + item.Surname.ToLower().Trim()).Contains(publisher.Name.ToLower().Trim() + " " + publisher.Surname.ToLower().Trim()))
                {
                    ModelState.AddModelError("Name", "Have already same name.Write different name!");
                    ModelState.AddModelError("Surname", "Have already same surname.Write different surname!");

                    return View(publisher);
                }
            }

            if (publisher.ImageFile != null)
            {
                if (!publisher.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct image format file");
                    return View();
                }
                if (!publisher.ImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                publisher.Image = publisher.ImageFile.SaveImg(_env.WebRootPath, "assets/images");
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Choose Image for Publisher");
                return View();
            }
            if (publisher.Resume == null)
            {
                ModelState.AddModelError("Resume", "Do not leave the field blank");
                return View();
            }


            _context.Publishers.Add(publisher);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int id)
        {

            Publisher publisher = _context.Publishers.FirstOrDefault(x => x.Id == id);
            if (publisher == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(publisher);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Publisher publisher)
        {


            Publisher existPublisher = _context.Publishers.FirstOrDefault(x => x.Id == id);
            if (existPublisher == null)
            {
                return RedirectToAction("index");
            }
            if (publisher.ImageFile != null)
            {
                if (!publisher.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!publisher.ImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", existPublisher.Image);
                existPublisher.Image = publisher.ImageFile.SaveImg(_env.WebRootPath, "assets/images");


            }


            if (!ModelState.IsValid)
            {
                return View();
            }


            existPublisher.Name = publisher.Name;
            existPublisher.Surname = publisher.Surname;
            existPublisher.Resume = publisher.Resume;



            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {
            Publisher publisher = _context.Publishers.FirstOrDefault(c => c.Id == id);
            if (publisher == null) return Json(new { status = 404 });

            Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", publisher.Image);

            _context.Publishers.Remove(publisher);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }
    }
}
