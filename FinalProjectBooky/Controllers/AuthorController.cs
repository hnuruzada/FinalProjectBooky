using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using FinalProjectBooky.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace FinalProjectBooky.Controllers
{
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;
        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? id)
        {

           
            Author author;
            if (id!=null)
            {
                author = _context.Authors.FirstOrDefault(a=>a.Id==id);
            }
            else
            {

             author = _context.Authors.FirstOrDefault();
            }
            AuthorVM authorVM = new AuthorVM
            {
                Authors = _context.Authors.Include(a => a.AuthorBooks).ThenInclude(ab => ab.Book).ToList(),
                Author = _context.Authors.Include(a => a.AuthorBooks).ThenInclude(ab => ab.Book).FirstOrDefault(a=>a.Id==author.Id),
                Books = _context.Books.Include(b => b.AuthorBooks).ThenInclude(ab => ab.Author).Include(b => b.Campaign).Include(b => b.BookCategories).ThenInclude(bc => bc.Category).Include(b => b.BookTags).ThenInclude(bt => bt.Tag).Where(b => b.AuthorBooks.Any(b => b.AuthorId ==author.Id )).ToList(),
            };
            if (authorVM.Author==null)
            {
                return NotFound();
            }


            return View(authorVM);
        }


    }
}
