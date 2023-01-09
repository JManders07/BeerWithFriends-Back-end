using Microsoft.AspNetCore.Mvc;
using BeerWithFriendsBackend.Models;
using BeerWithFriendsBackend.Logic;

namespace BeerWithFriendsBackend.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class BeerController : Controller
    {
        private readonly BeerLogic _beerLogic;

        public BeerController(BeerLogic beerlogic)
        {
            _beerLogic = beerlogic;
        }

        [Route("[action]")]
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

        [HttpGet("{id:int}")]
        public JsonResult Beer(int id)
        {
            Beer beer = _beerLogic.Beer(id);
            return Json(beer);
        }

        [HttpPost]
        public string NewBeer([FromBody] Beer beer)
        {
            if (beer != null)
            {
                try
                {
                    _beerLogic.NewBeer(beer);
                    return "Perfect";

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return "";
        }

        [HttpDelete("{id:int}")]
        public string DeleteBeer(int id)
        {
            if (id != null)
            {
                try
                {
                    _beerLogic.DeleteBeer(id);
                    return "Succeeded";

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return "";
        }

        [HttpPut("{id:int}")]
        public string EditBeer(int id, [FromBody] Beer beer)
        {
            beer.Id = id;
            try
            {
                _beerLogic.EditBeer(beer);
                return "Succeeded";
            }
            catch (Exception)
            {

                throw;
            }
        }
        
    }
}
