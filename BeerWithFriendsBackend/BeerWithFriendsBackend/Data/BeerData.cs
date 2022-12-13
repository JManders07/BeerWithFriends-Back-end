using BeerWithFriendsBackend.Models;

namespace BeerWithFriendsBackend.Data
{
    public class BeerData
    {
        private readonly BeerWithFriendsBackendContext _context;

        public BeerData(BeerWithFriendsBackendContext context)
        {
            _context = context;
        }

        public List<Beer> Beers()
        {
            return _context.Beer.ToList();
        }

        public void NewBeer(Beer beer)
        {
            _context.Add(beer);
            _context.SaveChanges();
        }
    }
}
