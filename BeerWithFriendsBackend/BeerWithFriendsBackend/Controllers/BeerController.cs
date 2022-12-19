using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeerWithFriendsBackend.Data;
using BeerWithFriendsBackend.Models;
using BeerWithFriendsBackend.Logic;

namespace BeerWithFriendsBackend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class BeerController : Controller
    {
        private readonly BeerLogic _beerLogic;

        public BeerController(BeerLogic beerlogic)
        {
            _beerLogic = beerlogic;
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

        public void Test()
        {
            int i = 0;
            i++;
        }

        public void Test2()
        {
            int i = 0;
            i++;
        }

        public void Test3()
        {
            int i = 0;
            i++;
        }
    }
}
