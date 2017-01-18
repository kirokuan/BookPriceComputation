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
            var distinctCount = books.Select(b => b.ID).Distinct().Count();
            var count = books.Count();
            decimal sum = 0;
            if (distinctCount > 1)
            {
                count -= distinctCount;
            }
            switch (distinctCount)
            {
                case 3:
                   
                    sum += distinctCount * BookPrice * 0.9m;
                    break;
                case 2:
                   
                    sum+=distinctCount * BookPrice * 0.95m;
                    break;
            }
            return sum+count*BookPrice;
        }

        private static int BookPrice
        {
            get {return 100;}
        }
    }
}
