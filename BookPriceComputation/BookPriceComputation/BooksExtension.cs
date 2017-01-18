using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPriceComputation
{
    public static class BooksExtension
    {
        public static decimal GetPrice(this IEnumerable<Book> books)
        {
            var countAll = books.Count();
            if (countAll > 1)
            {
                var distinctCount = books.Select(b => b.ID).Distinct().Count();
                if (distinctCount==3)
                {
                    return countAll * BookPrice * 0.9m;
                }
                if (distinctCount == 2)
                {
                    return countAll * BookPrice * 0.95m;
                }
                
            }
            return countAll*BookPrice;
        }

        private static int BookPrice
        {
            get {return 100;}
        }
    }
}
