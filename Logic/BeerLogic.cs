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

        public Beer Beer(int id)
        {
            return _beerData.Beer(id);
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

        public void DeleteBeer(int id)
        {
            _beerData.DeleteBeer(id);
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

        public void EditBeer(Beer beer)
        {
            _beerData.EditBeer(beer);
        }
    }
}
