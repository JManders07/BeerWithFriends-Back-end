using BeerWithFriendsContract;
using BeerWithFriendsDAL;
using BeerWithFriendsDAL.Data;

namespace BeerWithFriendsFactory
{
    public static class BeerFactory
    {
        private static readonly BeerWithFriendsContext _context;

       
        public static IBeerDAL GetBeerDAL()
        {
            return new BeerDAL(_context);
        }
    }
}