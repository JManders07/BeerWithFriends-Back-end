namespace BeerWithFriendsBackend.Models
{
    public class Review
    {
        public int Id { get; set; }
        public int BeerId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }

        public Review()
        {

        }

        public Review(Review review)
        {
            BeerId = review.BeerId;
            Comment = review.Comment;
            Rating = review.Rating;
        }
    }
}
