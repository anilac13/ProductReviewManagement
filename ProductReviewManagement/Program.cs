using System;
namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManagement productManagement = new ProductManagement();
            List<ProductReview> productReviews = new List<ProductReview>();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose option to perform \n1.Insert 25 Records \n2.Retrieve top 3 records \n3.Retrieve records whose rating is > 3 \n4.Retrieve Count of review " +
                    "\n5.Retrieve ProductID and Review \n6.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        productReviews.Add(new ProductReview { ProductID = 1, UserID = 1, Rating = 2.5, Review = "Bad", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 2, UserID = 2, Rating = 3.5, Review = "Good", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 3, UserID = 3, Rating = 2.8, Review = "Fine", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 4, UserID = 4, Rating = 3.5, Review = "Good", IsLike = false });
                        productReviews.Add(new ProductReview { ProductID = 5, UserID = 5, Rating = 3.0, Review = "Good", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 6, UserID = 6, Rating = 3.8, Review = "Good", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 7, UserID = 7, Rating = 4.0, Review = "Excellent", IsLike = false });
                        productReviews.Add(new ProductReview { ProductID = 8, UserID = 8, Rating = 4.5, Review = "Awesome", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 9, UserID = 9, Rating = 3.8, Review = "Bad", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 10, UserID = 10, Rating = 3.7, Review = "Good", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 11, UserID = 11, Rating = 2.0, Review = "Bad", IsLike = false });
                        productReviews.Add(new ProductReview { ProductID = 12, UserID = 12, Rating = 3.0, Review = "Fine", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 5, UserID = 13, Rating = 2.8, Review = "Fine", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 14, UserID = 14, Rating = 3.5, Review = "Good", IsLike = false });
                        productReviews.Add(new ProductReview { ProductID = 1, UserID = 15, Rating = 4.3, Review = "Excellent", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 16, UserID = 16, Rating = 3.9, Review = "Good", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 17, UserID = 17, Rating = 4.0, Review = "Excellent", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 12, UserID = 18, Rating = 4.5, Review = "Awesome", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 19, UserID = 19, Rating = 2.3, Review = "Bad", IsLike = false });
                        productReviews.Add(new ProductReview { ProductID = 20, UserID = 20, Rating = 2.7, Review = "Fine", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 2, UserID = 21, Rating = 3.3, Review = "Good", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 22, UserID = 22, Rating = 5.0, Review = "Awesome", IsLike = false });
                        productReviews.Add(new ProductReview { ProductID = 23, UserID = 23, Rating = 3.1, Review = "Good", IsLike = true });
                        productReviews.Add(new ProductReview { ProductID = 24, UserID = 24, Rating = 1.8, Review = "Bad", IsLike = false });
                        productReviews.Add(new ProductReview { ProductID = 25, UserID = 25, Rating = 3.4, Review = "Good", IsLike = true });
                        foreach (var data in productReviews)
                        {
                            Console.WriteLine($"ProductID:- {data.ProductID} \t UserID:- {data.UserID} \t Rating:- {data.Rating} " +
                                $"\t Review:- {data.Review} \t IsLike:- {data.IsLike}");
                        }
                        break;
                    case 2:
                        productManagement.TopRecords(productReviews);
                        break;
                    case 3:
                        productManagement.SelectedRecords(productReviews);
                        break;
                    case 4:
                        productManagement.CountOfRecords(productReviews);
                        break;
                    case 5:
                        productManagement.RetrieveIDAndReview(productReviews);
                        break;
                    case 6:
                        flag = false;
                        break;
                }
            }
        }
    }
}