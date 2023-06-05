using YummyTask.Entites;

namespace YummyTask.ChefVM
{
    public class ViewModelVM
    {
        public IEnumerable<Chef> Chefs { get;set; }

        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
