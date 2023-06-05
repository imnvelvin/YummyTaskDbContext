namespace YummyTask.Entites
{
    public class Testimonial
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string About { get; set; }
        public string Image { get; set; }

        public int ProfessionId { get; set; }

        public Profession Profession { get; set; }

    }
}
