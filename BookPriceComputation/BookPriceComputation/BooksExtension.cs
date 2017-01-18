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
            switch (distinctCount)
            {
                case 3:
                    return price * 0.9m;
                case 2:
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
