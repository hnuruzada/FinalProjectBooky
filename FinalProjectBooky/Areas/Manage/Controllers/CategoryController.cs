﻿using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]
    [Authorize(Roles = "SuperAdmin,Admin")]

    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1)
        {
            ViewBag.TotalPage = Math.Ceiling((decimal)_context.Categories.Count() / 10);
            ViewBag.CurrentPage = page;
            List<Category> model = _context.Categories.Skip((page - 1) * 10).Take(10).ToList();

            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            List<Category> Names = _context.Categories.Where(hs => hs.Name.ToLower().Contains(category.Name.ToLower())).ToList();
            if (!ModelState.IsValid)
            {
                return Content("Name must be max 50");
            }
            foreach (var item in Names)
            {
                if (item.Name.ToLower().Trim().Contains(category.Name.ToLower().Trim()))
                {
                    ModelState.AddModelError("Name", "You enter same Category Name.Write different category name!");
                    return View(category);
                }
            }

            _context.Categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Edit(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Category category, int id)
        {
            Category sameName = _context.Categories.FirstOrDefault(c => c.Name.ToLower().Trim() == category.Name.ToLower().Trim());

            if (!ModelState.IsValid)
            {
                return View();
            }
            Category existedCategory = _context.Categories.FirstOrDefault(c => c.Id == category.Id);
            if (existedCategory == null)
            {
                return NotFound();
            }

            if (sameName != null && sameName.Id != id)
            {
                ModelState.AddModelError("Name", "You enter same tag.Change other tag");
                return View(existedCategory);
            }

            existedCategory.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            Category category = _context.Categories.FirstOrDefault(c => c.Id == id);
            if (category == null) return Json(new { status = 404 });

            _context.Categories.Remove(category);
            _context.SaveChanges();

            return Json(new { status = 200 });

        }
    }
}
