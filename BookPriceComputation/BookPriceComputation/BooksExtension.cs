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
                if (books.Count() > 2 && !bookArr[0].Equals(bookArr[1]) && !bookArr[1].Equals(bookArr[2]))
                {
                    return books.Count() * 100 * 0.9m;
                }
                if (!bookArr[0].Equals(bookArr[1]))
                {
                    return books.Count()*100*0.95m;
                }
                
            }
            return books.Count()*100;
        }
    }
}
