using BeerWithFriendsBackend.Logic;
using BeerWithFriendsBackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BeerWithFriendsBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewController : Controller
    {
        private readonly ReviewLogic _reviewLogic;
        public ReviewController(ReviewLogic reviewlogic)
        {
            _reviewLogic = reviewlogic;
        }

        [HttpGet("{id:int}")]
        public JsonResult Reviews(int id)
        {
            List<Review> reviews = new();
            foreach (var review in _reviewLogic.Reviews(id))
            {
                reviews.Add(review);
            }
            return Json(reviews);
        }

        [HttpPost]
        public string NewReview([FromBody] Review review)
        {
            if (review != null)
            {
                try
                {
                    _reviewLogic.AddReview(review);
                    return "Perfect";

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return "";
        }
    }

    
}
