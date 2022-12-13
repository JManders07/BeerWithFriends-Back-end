using BeerWithFriendsBackend.Data;
using BeerWithFriendsBackend.Models;

namespace BeerWithFriendsBackend.Logic
{
    public class BeerLogic
    {
        private readonly BeerData _beerData;

        public BeerLogic(BeerData beerData)
        {
            _beerData = beerData;
        }

        public List<Beer> Beers()
        {
            return _beerData.Beers();
        }

        public void NewBeer(Beer beer)
        {
            _beerData.NewBeer(beer);
        }
    }
}
