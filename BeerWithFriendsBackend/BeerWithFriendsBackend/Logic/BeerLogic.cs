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

        public string NewBeer(Beer beer)
        {
            if (CheckNegativeAlcoholPercentage(beer))
            {
                _beerData.NewBeer(beer);
                return "Succes";
            }
            else
            {
                return "Not succeeded";
            }
            
            

        }

        private bool CheckNegativeAlcoholPercentage(Beer beer)
        {
            if (beer.AlcoholPercentage < 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
