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
    }
}
