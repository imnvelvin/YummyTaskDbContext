using Microsoft.EntityFrameworkCore;
using YummyTask.Entites;

namespace YummyTask.DAL
{
    public class RelationDbContext:DbContext
    {
        public RelationDbContext(DbContextOptions<RelationDbContext>options) : base(options) 
        { 

        }
        public DbSet<Chef> Chefs { get; set; }
        public DbSet<ChefSocialMediad> ChefSocialMediads { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }

    }
}
