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
            if (books.Count() > 1)
            {
                var bookArr = books.ToArray();
                if (bookArr[0].ID != bookArr[1].ID)
                {
                    return books.Count()*100*0.95m;
                }
            }
            return books.Count()*100;
        }
    }
}
