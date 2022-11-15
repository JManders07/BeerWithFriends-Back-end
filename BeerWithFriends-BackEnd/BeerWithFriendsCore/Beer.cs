using BeerWithFriendsDTO;

namespace BeerWithFriendsCore
{
    public class Beer
    {
        public Beer()
        {
        }
        public Beer(BeerDTO beerDTO)
        {
            Id = beerDTO.Id;
            Name = beerDTO.Name;
            AlcoholPercentage = beerDTO.AlcoholPercentage;
            Decription = beerDTO.Description;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal AlcoholPercentage { get; set; }
        public string Decription { get; set; }
    }
}