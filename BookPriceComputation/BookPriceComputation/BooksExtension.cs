using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPriceComputation
{
    public static class BooksExtension
    {
        public static  Dictionary<int,decimal> BooksOffMap=new Dictionary<int, decimal>()
        {
            {5,0.75m*5},
            {4,0.8m*4},
            {3,0.9m*3},
            {2,0.95m*2},
            {1,1m}
        }; 
        public static decimal GetPrice(this IEnumerable<Book> books)
        {
            var booksIds = books.Select(b => b.ID).ToList();
            decimal sum = 0;
            while (booksIds.Any())
            {
                sum += BooksOffMap[booksIds.Distinct().Count()] * BookPrice;
                var newBooksIds = new List<int>(booksIds.Distinct());
                foreach (var id in newBooksIds)
                {
                    booksIds.Remove(id);
                }

            }

            return sum;
        }

        private static int BookPrice
        {
            get {return 100;}
        }
    }
}
