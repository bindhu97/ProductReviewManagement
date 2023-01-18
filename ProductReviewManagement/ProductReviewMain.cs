using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class ProductReviewMain
    {
        List<ProductReview> productReviews = new List<ProductReview>();
        public void AddProductList(List<ProductReview> list)
        {
            this.productReviews = list;
        }
        public void RetrieveTopRecords()
        {
            var result = this.productReviews.Where(x => x.Rating == 5).Take(3);
            Display(result.ToList());
        }
        private void Display(List<ProductReview> productReviews)
        {
            foreach (var productReview in productReviews)
            {
                Console.WriteLine(productReview.ProductId + " " + productReview.UserId + " " + productReview.Rating + " " + productReview.Review + " " + productReview.IsLike + " ");
            }
        }
        public void RetrieveAllRecords()
        {
            var result = this.productReviews.Where(x => x.Rating > 3 &&
            (x.ProductId == 1 || x.ProductId == 4 || x.ProductId == 9));
            Display(result.ToList());
        }
        public void RetrieveAllRecordsGroupBy()
        {
            var result = this.productReviews.GroupBy(x => x.ProductId);
            foreach (var data in result)
            {
                Console.WriteLine(data.Count());
                Display(data.ToList());
            }
        }
    }
}
