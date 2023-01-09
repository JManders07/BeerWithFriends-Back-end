using BeerWithFriendsBackend.Models;

namespace BeerWithFriendsBackend.Data
{
    public class ReviewData
    {
        private readonly BeerWithFriendsBackendContext _context;

        public ReviewData(BeerWithFriendsBackendContext context)
        {
            _context = context;
        }

        public List<Review> Reviews(int id)
        {
            return _context.Review.Where(r => r.Id == id).ToList();
        }

        public void AddReview(Review review)
        {
            _context.Review.Add(review);
            _context.SaveChanges();
        }
    }
}
