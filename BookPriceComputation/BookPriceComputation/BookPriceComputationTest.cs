using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace BookPriceComputation
{
    class BookPriceComputationTest
    {
        private Book Book1
        {
            get { return new Book(1); }
        }

        private Book Book2
        {
            get { return new Book(2); }
        }

        private Book Book3
        {
            get { return new Book(3); }
        }
        private Book Book4
        {
            get { return new Book(4); }
        }
        private Book Book5
        {
            get { return new Book(5); }
        }

        private List<Book> books;

        [SetUp]
        public void SetUp()
        {
            books = new List<Book>();
            
        }

        [Test]
        public void BuyNothing()
        {
            Assert.AreEqual(0, books.GetPrice());
        }
        [Test]
        public void Buy1Book()
        {
            books.Add(Book1);
            Assert.AreEqual(100, books.GetPrice());
        }

        [Test]
        public void Buy2Book()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book1
            }); 
            Assert.AreEqual(200, books.GetPrice());
        }
        [Test]
        public void Buy2BookWithDiffId()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book2
            });
            Assert.AreEqual(190, books.GetPrice());
        }


        [Test]
        public void Buy3BooksWithDiffId()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book2,Book3
            });
            Assert.AreEqual(270, books.GetPrice());
        }

        [Test]
        public void Buy3BooksWith2DiffId()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book2,Book2
            });
            Assert.AreEqual(290, books.GetPrice());
        }
        [Test]
        public void Buy4BooksWithDiffId()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book2,Book3,Book4
            });
            Assert.AreEqual(320, books.GetPrice());
        }

        [Test]
        public void Buy5BooksWithDiffId()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book2,Book3,Book4,Book5
            });
            Assert.AreEqual(375, books.GetPrice());
        }

        [Test]
        public void Buy5BooksWith4DiffId()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book2,Book3,Book4,Book2
            });
            Assert.AreEqual(420, books.GetPrice());
        }

        
        [Test]
        public void Buy6BooksWith5DiffId()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book2,Book3,Book4,Book5,Book3
            });
            Assert.AreEqual(475, books.GetPrice());
        }

        [Test]
        public void Buy4BooksAs2Sets()
        {
            books.AddRange(new List<Book>()
            {
                Book1,Book5,Book1,Book5
            });
            Assert.AreEqual(380, books.GetPrice());
        }

        [Test]
        public void Buy10BooksAs2Sets()
        {
            var set=new List<Book>()
            {
                Book1,
                Book2,
                Book3,
                Book4,
                Book5
            };
            books.AddRange(set);
            books.AddRange(set);
            Assert.AreEqual(750, books.GetPrice());
        }

        [Test]
        public void Buy9BooksAs2DiffSets()
        {
            books.AddRange(new List<Book>()
            {
                  Book1,Book2,Book3,Book4,Book5,
                    Book1,Book3,Book4,Book5
            });
            Assert.AreEqual(695, books.GetPrice());
        }


    }
}
