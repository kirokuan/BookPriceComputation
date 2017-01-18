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
                if (books.Count() > 2 && bookArr[0].ID != bookArr[1].ID && bookArr[1].ID != bookArr[2].ID)
                {
                    return books.Count() * 100 * 0.9m;
                }
                if (bookArr[0].ID != bookArr[1].ID)
                {
                    return books.Count()*100*0.95m;
                }
                
            }
            return books.Count()*100;
        }
    }
}
