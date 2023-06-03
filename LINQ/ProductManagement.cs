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
        public readonly DataTable dataTable = new DataTable ();
        //method for getting top 3 ratings 
        public void TopProducts(List<ProductReview> listProductReview)
        {
            var topRating = ( from productReviews in listProductReview orderby productReviews.Rating descending 
                              select productReviews ).Take(3).ToList();

            Program.DisplayProduct((topRating));
        }
    }
}
