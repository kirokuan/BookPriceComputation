using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPriceComputation
{
    public static class BooksExtension
    {
        public static decimal GetPrice(this IEnumerable<Book> book)
        {
            if (book.Count() > 0) return 100;
            return 0;
        }
    }
}
