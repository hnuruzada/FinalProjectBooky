using FinalProjectBooky.DAL;
using FinalProjectBooky.Extensions;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public AuthorController(AppDbContext context,IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Authors.Count() / 2);
            ViewBag.CurrentPage = page;
            List<Author> author = _context.Authors.Include(f => f.AuthorBooks).ThenInclude(ab=>ab.Book).Skip((page - 1) * 2).Take(2).ToList();

            return View(author);
        }
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Author author)
        {

            List<Author> Names = _context.Authors.Where(hs => (hs.Name.ToLower().Trim() + " " + hs.Surname.ToLower().Trim()).Contains(author.Name.ToLower().Trim() + " "+ author.Surname.ToLower().Trim())).ToList();
            
            if (!ModelState.IsValid)
            {
                return View();
            }
            foreach (var item in Names)
            {
                if ((item.Name.ToLower().Trim() + " " + item.Surname.ToLower().Trim()).Contains(author.Name.ToLower().Trim()+ " " + author.Surname.ToLower().Trim()))
                {
                    ModelState.AddModelError("Name", "Have already same name.Write different name!");
                    ModelState.AddModelError("Surname", "Have already same surname.Write different surname!");

                    return View(author);
                }
            }

            if (author.ImageFile != null)
            {
                if (!author.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct image format file");
                    return View();
                }
                if (!author.ImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                author.Image = author.ImageFile.SaveImg(_env.WebRootPath, "assets/images");
            }
            else
            {
                ModelState.AddModelError("ImageFile", "Choose Image for Author");
                return View();
            }
            if(author.Resume == null)
            {
                ModelState.AddModelError("Resume", "Do not leave the field blank");
                return View();
            }


            _context.Authors.Add(author);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int id)
        {
            
            Author author = _context.Authors.FirstOrDefault(x => x.Id == id);
            if (author == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(author);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Author author)
        {
           

            Author existAuthor = _context.Authors.FirstOrDefault(x => x.Id == id);
            if (existAuthor == null)
            {
                return RedirectToAction("index");
            }
            if (author.ImageFile != null)
            {
                if (!author.ImageFile.IsImage())
                {
                    ModelState.AddModelError("ImageFile", "Choose correct format file");
                    return View();
                }
                if (!author.ImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ImageFile", "File must be max 2mb");
                    return View();
                }
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", existAuthor.Image);
                existAuthor.Image = author.ImageFile.SaveImg(_env.WebRootPath, "assets/images");


            }


            if (!ModelState.IsValid)
            {
                return View();
            }

            
            existAuthor.Name= author.Name;
            existAuthor.Surname= author.Surname;
            existAuthor.Resume= author.Resume;  

           

            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Delete(int id)
        {
            Author author= _context.Authors.FirstOrDefault(c => c.Id == id);
            if (author == null) return Json(new { status = 404 });

            Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", author.Image);

            _context.Authors.Remove(author);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }

    }
}
