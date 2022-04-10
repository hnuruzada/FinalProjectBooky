using FinalProjectBooky.DAL;
using FinalProjectBooky.Extensions;
using FinalProjectBooky.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectBooky.Areas.Manage.Controllers
{
    [Area("Manage")]

   
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }


        public IActionResult Index()
        {
            Setting setting = _context.Settings.Include(s=>s.FooterSocialMedias).FirstOrDefault();
            return View(setting);
        }


        public IActionResult Edit()
        {

            Setting setting = _context.Settings.Include(s => s.FooterSocialMedias).FirstOrDefault();
            if (setting == null) return NotFound();
            return View(setting);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Setting setting)
        {

            Setting settingEdit = _context.Settings.Include(s => s.FooterSocialMedias).FirstOrDefault(s => s.Id == setting.Id);
            if (!ModelState.IsValid) return NotFound();
            if (setting.LogoFile == null)
            {
                ModelState.AddModelError("LogoFile", "LogoFile is required");
            }
           
            if (setting.ParallaxFile == null)
            {
                ModelState.AddModelError("ParallaxFile", "ParallaxFile is required");
            }
            if (setting.FooterImageFile == null)
            {
                ModelState.AddModelError("FooterImageFile", "FooterImageFile is required");
            }
           

            if (setting.WebName == null)
            {
                ModelState.AddModelError("WebName", "WebName is required");
            }
           
            if (setting.PhoneNumber1 == null)
            {
                ModelState.AddModelError("PhoneNumber1", "PhoneNumber1 is required");
            }
            if (setting.LogoFile != null && setting.ParallaxFile != null && setting.FooterImageFile != null)
            {
                if (!setting.LogoFile.IsImage())
                {
                    ModelState.AddModelError("LogoFile", "File must be image file");
                    return View();
                }
                if (!setting.LogoFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("LogoFile", "file must be max size 2mb ");
                    return View();
                }
                if (!setting.ParallaxFile.IsImage())
                {
                    ModelState.AddModelError("ParallaxFile", "file must be image file");
                    return View();
                }
                if (!setting.ParallaxFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ParallaxFile", "file must be max size 2mb ");
                    return View();
                }
                if (!setting.FooterImageFile.IsImage())
                {
                    ModelState.AddModelError("FooterImageFile", "file must be image file");
                    return View();
                }
                if (!setting.FooterImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("FooterImageFile", "file must be max size 2mb ");
                    return View();
                }

                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.Logo);
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.ParallaxImage);
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.FooterImage);
                settingEdit.Logo = setting.LogoFile.SaveImg(_env.WebRootPath, "assets/images");
                settingEdit.ParallaxImage = setting.ParallaxFile.SaveImg(_env.WebRootPath, "assets/images");
                settingEdit.FooterImage = setting.FooterImageFile.SaveImg(_env.WebRootPath, "assets/images");

            }
            if (setting.LogoFile == null && setting.ParallaxFile != null && setting.FooterImageFile != null)
            {

                if (!setting.ParallaxFile.IsImage())
                {
                    ModelState.AddModelError("ParallaxFile", "file must be image file");
                    return View();
                }
                if (!setting.ParallaxFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ParallaxFile", "file must be max size 2mb ");
                    return View();
                }
                if (!setting.FooterImageFile.IsImage())
                {
                    ModelState.AddModelError("FooterImageFile", "file must be image file");
                    return View();
                }
                if (!setting.FooterImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("FooterImageFile", "file must be max size 2mb ");
                    return View();
                }


                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.ParallaxImage);
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.FooterImage);

                settingEdit.ParallaxImage = setting.ParallaxFile.SaveImg(_env.WebRootPath, "assets/images");
                settingEdit.FooterImage = setting.FooterImageFile.SaveImg(_env.WebRootPath, "assets/images");

            }
            if (setting.LogoFile != null && setting.ParallaxFile == null && setting.FooterImageFile != null)
            {
                if (!setting.LogoFile.IsImage())
                {
                    ModelState.AddModelError("LogoFile", "file must be image file");
                    return View();
                }
                if (!setting.LogoFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("LogoFile", "file must be max size 2mb ");
                    return View();
                }

                if (!setting.FooterImageFile.IsImage())
                {
                    ModelState.AddModelError("FooterImageFile", "file must be image file");
                    return View();
                }
                if (!setting.FooterImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("FooterImageFile", "file must be max size 2mb ");
                    return View();
                }

                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.Logo);

                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.FooterImage);
                settingEdit.Logo = setting.LogoFile.SaveImg(_env.WebRootPath, "assets/images");

                settingEdit.FooterImage = setting.FooterImageFile.SaveImg(_env.WebRootPath, "assets/images");

            }
            if (setting.LogoFile != null && setting.ParallaxFile != null && setting.FooterImageFile == null)
            {
                if (!setting.LogoFile.IsImage())
                {
                    ModelState.AddModelError("LogoFile", "file must be image file");
                    return View();
                }
                if (!setting.LogoFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("LogoFile", "file must be max size 2mb ");
                    return View();
                }
                if (!setting.ParallaxFile.IsImage())
                {
                    ModelState.AddModelError("ParallaxFile", "file must be image file");
                    return View();
                }
                if (!setting.ParallaxFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ParallaxFile", "file must be max size 2mb ");
                    return View();
                }


                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.Logo);
                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.ParallaxImage);

                settingEdit.Logo = setting.LogoFile.SaveImg(_env.WebRootPath, "assets/images");
                settingEdit.ParallaxImage = setting.ParallaxFile.SaveImg(_env.WebRootPath, "assets/images");


            }
            if (setting.LogoFile == null && setting.ParallaxFile == null && setting.FooterImageFile != null)
            {


                if (!setting.FooterImageFile.IsImage())
                {
                    ModelState.AddModelError("FooterImageFile", "file must be image file");
                    return View();
                }
                if (!setting.FooterImageFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("FooterImageFile", "file must be max size 2mb ");
                    return View();
                }


                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.FooterImage);

                settingEdit.FooterImage = setting.FooterImageFile.SaveImg(_env.WebRootPath, "assets/images");

            }
            if (setting.LogoFile != null && setting.ParallaxFile == null && setting.FooterImageFile == null)
            {
                if (!setting.LogoFile.IsImage())
                {
                    ModelState.AddModelError("LogoFile", "file must be image file");
                    return View();
                }
                if (!setting.LogoFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("LogoFile", "file must be max size 2mb ");
                    return View();
                }


                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.Logo);

                settingEdit.Logo = setting.LogoFile.SaveImg(_env.WebRootPath, "assets/images");


            }
            if (setting.LogoFile == null && setting.ParallaxFile != null && setting.FooterImageFile == null)
            {

                if (!setting.ParallaxFile.IsImage())
                {
                    ModelState.AddModelError("ParallaxFile", "file must be image file");
                    return View();
                }
                if (!setting.ParallaxFile.IsSizeOkay(2))
                {
                    ModelState.AddModelError("ParallaxFile", "file must be max size 2mb ");
                    return View();
                }


                Helpers.Helper.DeleteImg(_env.WebRootPath, "assets/images", settingEdit.ParallaxImage);


                settingEdit.ParallaxImage = setting.ParallaxFile.SaveImg(_env.WebRootPath, "assets/images");


            }
            List<FooterSocialMedia> existFSocialMeadias = _context.FooterSocialMedias.Where(x => x.SettingId == setting.Id).ToList();


            List<FooterSocialMedia> fsocialMedia = setting.FooterSocialMedias;
            if (fsocialMedia != null)
            {
                _context.Settings.FirstOrDefault(x => x.Id == setting.Id).FooterSocialMedias = fsocialMedia;
            }
            if (existFSocialMeadias != null)
            {
                _context.FooterSocialMedias.RemoveRange(existFSocialMeadias);
            }
          

            settingEdit.WebName = setting.WebName;
            settingEdit.Email = setting.Email;
            settingEdit.PhoneNumber1 = setting.PhoneNumber1;
            settingEdit.PhoneNumber2 = setting.PhoneNumber2;
            settingEdit.FooterSocialMedias=setting.FooterSocialMedias;
            
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

    }
}
