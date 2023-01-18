// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using ProductReviewManagement;
public class Program
{
    public static void Main(string[] args)
    {
        List<ProductReview> productReviews = new List<ProductReview>()
        {
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 5, Review = "Very Good", IsLike = true },
            new ProductReview() { ProductId = 1, UserId = 1, Rating = 4, Review = "Good", IsLike = true },
            new ProductReview() { ProductId = 3, UserId = 2, Rating = 5, Review = "Very Good", IsLike = false },
            new ProductReview() { ProductId = 4, UserId = 2, Rating = 3, Review = "Average", IsLike = false },
            new ProductReview() { ProductId = 5, UserId = 3, Rating = 4, Review = "Good", IsLike = true },
            new ProductReview() { ProductId = 6, UserId = 4, Rating = 2, Review = "Average", IsLike = false },
            new ProductReview() { ProductId = 7, UserId = 7, Rating = 4, Review = "Good", IsLike = true },
            new ProductReview() { ProductId = 8, UserId = 8, Rating = 2, Review = "Average", IsLike = false },
            new ProductReview() { ProductId = 9, UserId = 2, Rating = 2, Review = "Average", IsLike = false },
            new ProductReview() { ProductId = 10, UserId = 3, Rating = 1, Review = "Bad", IsLike = false },
            new ProductReview() { ProductId = 11, UserId = 5, Rating = 2, Review = "Average", IsLike = false },
            new ProductReview() { ProductId = 12, UserId = 6, Rating = 3, Review = "Average", IsLike = false },
            new ProductReview() { ProductId = 13, UserId = 5, Rating = 4, Review = "Good", IsLike = true },
            new ProductReview() { ProductId = 14, UserId = 7, Rating = 1, Review = "Bad", IsLike = false },
            new ProductReview() { ProductId = 15, UserId = 7, Rating = 2, Review = "Average", IsLike = false },
            new ProductReview() { ProductId = 16, UserId = 8, Rating = 5, Review = "Very Good", IsLike = true }
        };
        ProductReviewMain productReview = new ProductReviewMain();
        productReview.AddProductList(productReviews);
        //productReview.RetrieveTopRecords();
        productReview.RetrieveAllRecords();
    }
}
