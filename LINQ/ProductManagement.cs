using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class ProductManagement
    {
        public readonly DataTable dataTable = new DataTable();
        //method for getting top 3 ratings 
        /*public void TopProducts(List<ProductReview> listProductReview)
        {
            Console.WriteLine("Top 3 ratings from the record are : ");
            var topRating = ( from productReviews in listProductReview orderby productReviews.Rating descending 
                              select productReviews ).Take(3).ToList();

            Program.DisplayProduct((topRating));
        }
        */
        //method for getting gratings greater than 3 of ProductId 1, 4 and  9. 
        /*public void SelectedRatings(List<ProductReview> listProductReview)
        {

            var selectedRating = (from productReviews in listProductReview
                                  where (productReviews.ProductId == 1 || productReviews.ProductId == 4 || productReviews.ProductId == 9)
                                  && productReviews.Rating > 3
                                  select productReviews).ToList();

            Program.DisplayProduct((selectedRating));
        }
        */
        //method for getting count of same ProductIds.
        public void CountOfRecords(List<ProductReview> listProductReview)
        {
            var count = listProductReview.GroupBy(x => x.ProductId).Select(x => new {ProductId = x.Key, Count = x.Count()});
            
            Console.WriteLine("ProductId -- Count" );
            foreach (var item in count)
            {
                Console.WriteLine("     " + item.ProductId + "    --   " + item.Count);
            }
        }

    }
}
