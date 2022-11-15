namespace BeerWithFriendsDTO
{
    public class BeerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AlcoholPercentage { get; set; }
        public string Description { get; set; }

        public BeerDTO()
        {
        }
    }
}