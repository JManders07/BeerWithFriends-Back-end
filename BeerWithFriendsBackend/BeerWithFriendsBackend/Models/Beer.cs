namespace BeerWithFriendsBackend.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal AlcoholPercentage { get; set; }

        public Beer()
        {

        }

        public Beer(Beer beer)
        {
            Name = beer.Name;
            Description = beer.Description;
            AlcoholPercentage = beer.AlcoholPercentage;
        }
    }
}
