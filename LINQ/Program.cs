using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<ProductReview> list = new List<ProductReview>()
            {
                new ProductReview() { ProductId = 01, UserId = 01, Review = "Good", IsLike = true, Rating = 4 },
                new ProductReview() { ProductId = 02, UserId = 02, Review = "Bad", IsLike = true, Rating = 2.5 },
                new ProductReview() { ProductId = 03, UserId = 03, Review = "Good", IsLike = false, Rating = 2 },
                new ProductReview() { ProductId = 04, UserId = 04, Review = "Good", IsLike = true, Rating = 4.5 },
                new ProductReview() { ProductId = 05, UserId = 05, Review = "Bad", IsLike = false, Rating = 2 },
                new ProductReview() { ProductId = 06, UserId = 06, Review = "Bad", IsLike = true, Rating = 3 },
                new ProductReview() { ProductId = 07, UserId = 07, Review = "Good", IsLike = true, Rating = 4.5 },
                new ProductReview() { ProductId = 08, UserId = 08, Review = "Good", IsLike = true, Rating = 4 },
                new ProductReview() { ProductId = 09, UserId = 09, Review = "Good", IsLike = true, Rating = 3.5 },
                new ProductReview() { ProductId = 01, UserId = 10, Review = "Bad", IsLike = false, Rating = 2 },
                new ProductReview() { ProductId = 02, UserId = 11, Review = "Bad", IsLike = true, Rating = 2.5 },
                new ProductReview() { ProductId = 01, UserId = 12, Review = "Bad", IsLike = true, Rating = 2.5 },
                new ProductReview() { ProductId = 07, UserId = 13, Review = "Good", IsLike = true, Rating = 5 },
                new ProductReview() { ProductId = 06, UserId = 14, Review = "Good", IsLike = true, Rating = 4 },
                new ProductReview() { ProductId = 07, UserId = 15, Review = "Bad", IsLike = false, Rating = 2 },
                new ProductReview() { ProductId = 06, UserId = 16, Review = "Good", IsLike = true, Rating = 3.5 },
                new ProductReview() { ProductId = 07, UserId = 17, Review = "Good", IsLike = true, Rating = 4 },
                new ProductReview() { ProductId = 01, UserId = 18, Review = "Bad", IsLike = false, Rating = 1.5 },
                new ProductReview() { ProductId = 02, UserId = 19, Review = "Bad", IsLike = true, Rating = 2.5 },
                new ProductReview() { ProductId = 03, UserId = 20, Review = "Bad", IsLike = false, Rating = 1.5 },
                new ProductReview() { ProductId = 09, UserId = 21, Review = "Good", IsLike = true, Rating = 5 },
                new ProductReview() { ProductId = 02, UserId = 22, Review = "Good", IsLike = true, Rating = 4 },
                new ProductReview() { ProductId = 05, UserId = 23, Review = "Bad", IsLike = false, Rating = 1 },
                new ProductReview() { ProductId = 04, UserId = 24, Review = "Good", IsLike = true, Rating = 3.5 },
                new ProductReview() { ProductId = 06, UserId = 25, Review = "Bad", IsLike = false, Rating = 2 },
            };
            //Object of ProductManagement class
            ProductManagement productManagement = new ProductManagement();
            //UC2
            //for top 3 ratings
            //productManagement.TopProducts(list);
            //UC3
            //for Ratings greater than 3
            productManagement.SelectedRatings(list);

        }
        //Dispaly Method
        public static void DisplayProduct(List<ProductReview> list)
        {
            foreach (ProductReview product in list)
            {
                Console.WriteLine(product);
            }
        }
        
    }
}
