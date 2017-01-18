using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookPriceComputation
{
    public class Book 
    {
        public Book(int id)
        {
            ID = id;
        }
        public int ID { get; set; }
        public override bool Equals(object obj)
        {
            var anotherBook = obj as Book;
            if (anotherBook == null) return false;
            else
            {
                return anotherBook.ID == this.ID;
            }

        }

    
    }

    public class BookComparer : IEqualityComparer<Book>
    {
        public bool Equals(Book book1, Book book2)
        {
            return book1.Equals(book2);
        }

        public int GetHashCode(Book book)
        {
            return book.ID;
        }
    }
}
