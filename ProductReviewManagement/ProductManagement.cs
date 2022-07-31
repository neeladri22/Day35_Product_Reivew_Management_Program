using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    internal class ProductManagement
    {
        static List<ProductReview> DataTable;
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

        //UC4-Retrieve count of review present for each Product ID
        public static void RetrieveCountofReviewForEachProiductId(List<ProductReview> Product)
        {
            var result = Product.GroupBy(P => P.ProductId).Select(Pi => new { ProductId = Pi.Key, count = Pi.Count() });
            Console.WriteLine("\nRetrieve count of review present for each Product ID :");
            foreach (var pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nReview Count : " + pm.count);
            }
        }

        //UC5-Retrieve only Product Id and Review 
        public static void RetrieveOnlyProductIdAndReview(List<ProductReview> Product)
        {
            var result = (from PM in Product orderby PM.ProductId select PM).ToList();
            Console.WriteLine("\nRetrieve only Product Id and Review :");
            foreach (var pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nReview : " + pm.Review);
            }

        }

        //UC6-Skip Top 5 Records from list
        public static void SkipTop5Records(List<ProductReview> Product)
        {
            var result = (from PM in Product select PM).Skip(5);
            Console.WriteLine("\nSkipping Top 5 Records :");
            foreach (ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nUser ID: " + pm.UserId +
                                    "\nRating: " + pm.Rating +
                                    "\nReview: " + pm.Review +
                                    "\nIS Liked : " + pm.isLike);
            }
        }
        //UC7-Retrieve only Product ID and Review
        public static void RetrieveOnlyProductIdandReview(List<ProductReview> Product)
        {
            var result = (from PM in Product select PM);
            Console.WriteLine("\nRetrieve product ID and Review:");
            foreach (ProductReview pm in result)
            {
                Console.WriteLine("\nProduct ID: " + pm.ProductId +
                                    "\nReview: " + pm.Review);
            }
        }
    }
}
