using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YummyTask.ChefVM;
using YummyTask.DAL;
using YummyTask.Entites;

namespace YummyTask.Controllers
{
    public class HomeController : Controller
    {
        private readonly RelationDbContext _context;

        public HomeController(RelationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Testimonial> testimonials = _context.Testimonials.Include(c=> c.Profession).AsEnumerable();
            IEnumerable<Chef> chefs = _context.Chefs.Include(c => c.ChefSocialMediad).Include(c => c.Profession).AsEnumerable();

            ViewModelVM model = new()
            {
                Chefs = chefs,
                Testimonials = testimonials,
            };

            return View(model);
        }
    }
}
