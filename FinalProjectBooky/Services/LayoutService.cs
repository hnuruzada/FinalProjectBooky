using FinalProjectBooky.DAL;
using FinalProjectBooky.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FinalProjectBooky.Services
{
    public class LayoutService
    {
        private readonly AppDbContext _context;
        public LayoutService(AppDbContext context)
        {
            _context = context;
        }

        public Setting GetSettingData()
        {
            Setting data = _context.Settings.Include(s => s.FooterSocialMedias).FirstOrDefault();
            return data;
        }
    }
}
