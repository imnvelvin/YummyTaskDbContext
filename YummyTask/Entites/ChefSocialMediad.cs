namespace YummyTask.Entites
{
    public class ChefSocialMediad
    {
        public int Id { get; set; }
        public string FbUrl { get; set; }
        public string IgUrl { get; set; }
        public string TwitterUrl { get; set; }
        public string inUrl { get; set; }
        

       public Chef Chef { get; set; }
        public int ChefId { get; set; }



    }
}
