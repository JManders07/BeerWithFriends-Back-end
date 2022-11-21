using BeerWithFriendsDTO;

namespace BeerWithFriendsContract
{

    public interface IBeerDAL
    {
        List<BeerDTO> Beers();
    }
}