﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ProductManagement
    {
        //Top 3 Records of High Rating
        public static void Top3Records(List<ProductReview> Product)
        {
            var result = (from PM in Product orderby PM.Rating descending select PM).Take(3);
            Console.WriteLine("Top 3 Records are :");
            foreach (ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nUser ID: " + pm.UserId +
                                    "\nRating: " + pm.Rating +
                                    "\nReview: " + pm.Review +
                                    "\nIS Liked : " + pm.isLike);
            }
        }

        //Retrieve all records who's Rating is Greater that 3 and Product ID is 1 or 4 or 9
        public static void RetriveAllRecordWhosRatingGreaterThan3(List<ProductReview> Product)
        {
            var result = (from PM in Product where (PM.ProductId > 3) && (PM.ProductId == 1 || PM.ProductId == 4 || PM.ProductId == 9) select PM).ToList();
            Console.WriteLine("\nRetrieve all records who's Rating is Greater than 3 and Product ID is 14 or 4 or 9 :");
            foreach (ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nUser ID: " + pm.UserId +
                                    "\nRating: " + pm.Rating +
                                    "\nReview: " + pm.Review +
                                    "\nIS Liked : " + pm.isLike);
            }

        }
    }
}
