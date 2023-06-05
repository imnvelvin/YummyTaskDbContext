using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyTask.Entites;

namespace YummyTask.DAL
{
    public class ChefController:Controller
    {
        private readonly RelationDbContext _context;

        public ChefController(RelationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int id)
        {
            Chef chef = _context.Chefs.Include(c => c.ChefSocialMediad).Include(c => c.Profession).ToList().FirstOrDefault(x => x.Id == id);
            return View(chef);
        }
    }
}
