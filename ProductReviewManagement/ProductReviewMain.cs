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
    }
}
