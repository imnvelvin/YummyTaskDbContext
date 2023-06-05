namespace YummyTask.Entites
{
    public class Chef
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Profession Profession { get; set; }
        public int ProfessionId { get; set; }
        public ChefSocialMediad ChefSocialMediad { get; set; }



    }
}
