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
}
