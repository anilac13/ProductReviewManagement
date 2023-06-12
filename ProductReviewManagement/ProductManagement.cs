using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductManagement
    {
        public void TopRecords(List<ProductReview> review)
        {
            var top3Records = (from productReview in review
                               orderby productReview.Rating descending
                               select productReview).Take(3);
            Console.WriteLine("Top 3 Records are \n=====================================================");
            foreach (var data in top3Records)
            {
                Console.WriteLine($"ProductID:- {data.ProductID} \t UserID:- {data.UserID} \t Rating:- {data.Rating} " +
                    $"\t Review:- {data.Review} \t IsLike:- {data.IsLike}");
            }
        }
        public void SelectedRecords(List<ProductReview> review)
        {
            var result = (from productReview in review
                          where (productReview.ProductID == 1 || productReview.ProductID == 4 || productReview.ProductID == 9)
                          && productReview.Rating > 3
                          select productReview);

            /*var result = (from productReview in review
                          where productReview.ProductID == 1 && productReview.Rating > 3 
                          || productReview.ProductID == 4 && productReview.Rating > 3 
                          || productReview.ProductID == 9 && productReview.Rating > 3
                          select productReview);*/

            foreach (var data in result)
            {
                Console.WriteLine($"ProductID:- {data.ProductID} \t UserID:- {data.UserID} \t Rating:- {data.Rating} \t Review:- {data.Review} \t Islike:- {data.IsLike}");
            }
        }
        public void CountOfRecords(List<ProductReview> review)
        {
            var result = review.GroupBy(a => a.ProductID).Select(a => new { ProductID = a.Key, Count = a.Count() });
            foreach (var data in result)
            {
                Console.WriteLine($"ProductID:- {data.ProductID} \t Count:- {data.Count}");
            }
        }
        public void RetrieveIDAndReview(List<ProductReview> listReview)
        {
            var result = (from productReview in listReview
                          select productReview);
            foreach (var data in result)
            {
                Console.WriteLine($"ProductID:- {data.ProductID} \t Review:- {data.Review}");
            }
        }
    }
}
