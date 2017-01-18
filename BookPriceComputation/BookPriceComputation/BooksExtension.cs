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
            var booksIds = books.Select(b => b.ID).ToList();
            decimal sum = 0;
            while (booksIds.Any())
            {
                decimal off = 1;
                switch (booksIds.Distinct().Count())
                {
                    case 5:
                        off = .75m;
                        break;
                    case 4:
                        off = 0.8m;
                        break;
                    case 3:
                        off = 0.9m;
                        break;
                    case 2:
                        off = 0.95m;
                        break;
                }
                sum += booksIds.Distinct().Count()*BookPrice*off;
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
