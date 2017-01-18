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
            decimal sum = 0;
            var newBooks=new List<Book>(books);
            while (newBooks.Any())
            {
                var distinct = newBooks.Distinct(new BookComparer());
                sum += BooksOffMap[distinct.Count()] * BookPrice;
                newBooks = newBooks.ExceptOnce(distinct);
            }
            return sum;
        }

        private static List<Book> ExceptOnce(this ICollection<Book> booksIds, IEnumerable<Book> distinct)
        {
            foreach (var item in new List<Book>(distinct))
            {
                booksIds.Remove(item);
            }
            return new List<Book>(booksIds);
        }
        private static int BookPrice
        {
            get {return 100;}
        }
    }
}
