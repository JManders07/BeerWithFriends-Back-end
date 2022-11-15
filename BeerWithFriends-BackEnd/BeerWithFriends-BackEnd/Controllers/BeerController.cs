using BeerWithFriendsCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeerWithFriends_BackEnd.Controllers
{
    [Route("api/[controller][action]")]
    [ApiController]
    public class BeerController : Controller
    {
        private readonly BeerLogic _beerLogic;

        public BeerController(BeerLogic beerLogic)
        {
            _beerLogic = beerLogic;
        }

        [HttpGet]
        public JsonResult Beers()
        {
            List<Beer> beers = new();
            foreach (var beer in _beerLogic.Beers())
            {
                beers.Add(beer);
            }
            return Json(beers);
        }
    }
}
