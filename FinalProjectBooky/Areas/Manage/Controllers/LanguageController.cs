using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]

    public class LanguageController : Controller
    {
        private readonly AppDbContext _context;
        public LanguageController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Categories.Count() / 6);
            ViewBag.CurrentPage = page;
            List<Language> languages = _context.Languages.Skip((page - 1) * 6).Take(6).ToList();

            return View(languages);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Language language)
        {
            List<Language> lang = _context.Languages.Where(hs => hs.Name.ToLower().Contains(language.Name.ToLower())).ToList();
            if (!ModelState.IsValid)
            {
                return Content("language must be max 50");
            }
            foreach (var item in lang)
            {
                if (item.Name.ToLower().Trim().Contains(language.Name.ToLower().Trim()))
                {
                    ModelState.AddModelError("Name", "You enter same Category Name.Write different category name!");
                    return View(language);
                }
            }

            _context.Languages.Add(language);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            Language language = _context.Languages.FirstOrDefault(c => c.Id == id);
            return View(language);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Language language, int id)
        {
            Language sameName = _context.Languages.FirstOrDefault(c => c.Name.ToLower().Trim() == language.Name.ToLower().Trim());

            if (!ModelState.IsValid)
            {
                return View();
            }
            Language existedLanguage = _context.Languages.FirstOrDefault(c => c.Id == language.Id);
            if (existedLanguage == null)
            {
                return NotFound();
            }

            if (sameName != null && sameName.Id != id)
            {
                ModelState.AddModelError("Name", "You enter same language.Change other language");
                return View(existedLanguage);
            }
            existedLanguage.Name = language.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Language language = _context.Languages.FirstOrDefault(c => c.Id == id);
            if (language == null) return Json(new { status = 404 });

            _context.Languages.Remove(language);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }
    }
}
