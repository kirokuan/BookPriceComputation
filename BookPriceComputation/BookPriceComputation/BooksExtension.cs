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
            var distinctCount = books.Select(b => b.ID).Distinct().Count();
            var price = countAll*BookPrice;
            if (distinctCount==3)
            {
                 return price * 0.9m;
            }
            if (distinctCount == 2)
            {
                 return price * 0.95m;
            }
            return price;
        }

        private static int BookPrice
        {
            get {return 100;}
        }
    }
}
