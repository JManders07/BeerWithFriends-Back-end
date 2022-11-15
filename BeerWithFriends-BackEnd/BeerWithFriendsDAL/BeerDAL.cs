using BeerWithFriendsContract;
using BeerWithFriendsDAL.Data;
using BeerWithFriendsDTO;

namespace BeerWithFriendsDAL
{
    public class BeerDAL : IBeerDAL
    {
        private readonly Data.BeerWithFriendsContext _context;

        public BeerDAL(BeerWithFriendsContext context)
        {
            _context = context;
        }

        public List<BeerDTO> Beers()
        {
            return _context.Beer.ToList();
        }
    }
}