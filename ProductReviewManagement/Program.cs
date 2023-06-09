using System;
namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> productReviews = new List<ProductReview>()
            {
                new ProductReview() {ProductID = 1, UserID =1, Rating=2.5, Review="Bad", IsLike=true},
                new ProductReview() {ProductID = 2, UserID =2, Rating=3.5, Review="Good", IsLike = true},
                new ProductReview() {ProductID = 3, UserID =3, Rating=2.8, Review="Fine", IsLike = true},
                new ProductReview() {ProductID = 4, UserID =4, Rating=3.5, Review="Good", IsLike = false},
                new ProductReview() {ProductID = 5, UserID =5, Rating=3.0, Review="Good", IsLike = true},
                new ProductReview() {ProductID = 6, UserID =6, Rating=3.8, Review="Good", IsLike = true},
                new ProductReview() {ProductID = 7, UserID =7, Rating=4.0, Review="Excellent",IsLike = false},
                new ProductReview() {ProductID = 8, UserID =8, Rating=4.5, Review="Awesome", IsLike = true},
                new ProductReview() {ProductID = 9, UserID =9, Rating=2.7, Review="Bad", IsLike = true},
                new ProductReview() {ProductID = 10, UserID =10, Rating=3.7, Review="Good", IsLike = true},
                new ProductReview() {ProductID = 11, UserID =11, Rating=2.0, Review="Bad",IsLike=false},
                new ProductReview() {ProductID = 12, UserID =12, Rating=3.0, Review="Fine",IsLike = true},
                new ProductReview() {ProductID = 13, UserID =13, Rating=2.8, Review="Fine", IsLike = true},
                new ProductReview() {ProductID = 14, UserID =14, Rating=3.5, Review="Good", IsLike = false},
                new ProductReview() {ProductID = 15, UserID =15, Rating=4.3, Review="Excellent", IsLike = true},
                new ProductReview() {ProductID = 16, UserID =16, Rating=3.9, Review="Good", IsLike = true},
                new ProductReview() {ProductID = 17, UserID =17, Rating=4.0, Review="Excellent",IsLike = true},
                new ProductReview() {ProductID = 18, UserID =18, Rating=4.5, Review="Awesome", IsLike = true},
                new ProductReview() {ProductID = 19, UserID =19, Rating=2.3, Review="Bad", IsLike = false},
                new ProductReview() {ProductID = 20, UserID =20, Rating=2.7, Review="Fine", IsLike = true},
                new ProductReview() {ProductID = 21, UserID =21, Rating=3.3, Review="Good", IsLike = true},
                new ProductReview() {ProductID = 22, UserID =22, Rating=5.0, Review="Awesome", IsLike = false},
                new ProductReview() {ProductID = 23, UserID =23, Rating=3.1, Review="Good", IsLike = true},
                new ProductReview() {ProductID = 24, UserID =24, Rating=1.8, Review="Bad", IsLike = false},
                new ProductReview() {ProductID = 25, UserID =25, Rating=3.4, Review="Good", IsLike = true}
            };
        }
    }
}