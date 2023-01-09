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

        public void DeleteBeer(int id)
        {
            var beer = _context.Beer.Find(id);
            _context.Beer.Remove(beer);
            _context.SaveChanges();
        }

        public Beer Beer(int id)
        {
            return _context.Beer.FirstOrDefault(b => b.Id == id);
        }

        public void EditBeer(Beer beer)
        {
            _context.Update(beer);
            _context.SaveChanges();

        }
    }
}
