using BeerWithFriendsBackend.Data;
using BeerWithFriendsBackend.Models;

namespace BeerWithFriendsBackend.Logic
{
    public class ReviewLogic
    {
        private readonly ReviewData _reviewData;
        public ReviewLogic(ReviewData reviewData)
        {
            _reviewData = reviewData;
        }

        public List<Review> Reviews(int id)
        {
            return _reviewData.Reviews(id);
        }

        public void AddReview(Review review)
        {
            _reviewData.AddReview(review);
        }
    }
}
