using BeerWithFriendsContract;

namespace BeerWithFriendsCore
{
    public class BeerLogic
    {
        private readonly IBeerDAL _beerDAL;

        public BeerLogic(IBeerDAL beerDAL)
        {
            _beerDAL = beerDAL;
        }

        public List<Beer> Beers()
        {
            List<Beer> beers = ReturnBeers();
            return beers;
        }

        private List<Beer> ReturnBeers()
        {
            List<Beer> products = new();
            foreach (var item in _beerDAL.Beers())
            {
                products.Add(new Beer(item));
            }

            return products;
        }

        //te
    }
}
