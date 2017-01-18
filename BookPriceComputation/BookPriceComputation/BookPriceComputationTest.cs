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

        [Test]
        public void BuyNothing()
        {
            var books=new List<Book>();
            Assert.AreEqual(0, books.GetPrice());
        }
        [Test]
        public void Buy1Book()
        {
            var books = new List<Book>()
            {
                Book1
            };
            Assert.AreEqual(100, books.GetPrice());
        }

        [Test]
        public void Buy2Book()
        {
            var books = new List<Book>()
            {
                Book1,Book1
            };
            Assert.AreEqual(200, books.GetPrice());
        }
        [Test]
        public void Buy2BookWithDiffId()
        {
            var books = new List<Book>()
            {
                Book1,Book2
            };
            Assert.AreEqual(190, books.GetPrice());
        }


        [Test]
        public void Buy3BooksWithDiffId()
        {
            var books = new List<Book>()
            {
                Book1,Book2,Book3
            };
            Assert.AreEqual(270, books.GetPrice());
        }

        [Test]
        public void Buy3BooksWith2DiffId()
        {
            var books = new List<Book>()
            {
                Book1,Book2,Book2
            };
            Assert.AreEqual(290, books.GetPrice());
        }
        [Test]
        public void Buy4BooksWithDiffId()
        {
            var books = new List<Book>()
            {
                Book1,Book2,Book3,Book4
            };
            Assert.AreEqual(320, books.GetPrice());
        }

        [Test]
        public void Buy5BooksWithDiffId()
        {
            var books = new List<Book>()
            {
                Book1,Book2,Book3,Book4,Book5
            };
            Assert.AreEqual(375, books.GetPrice());
        }

        [Test]
        public void Buy5BooksWith4DiffId()
        {
            var books = new List<Book>()
            {
                Book1,Book2,Book3,Book4,Book2
            };
            Assert.AreEqual(420, books.GetPrice());
        }
        [Test]
        public void Buy6BooksWith5DiffId()
        {
            var books = new List<Book>()
            {
                Book1,Book2,Book3,Book4,Book5,Book3
            };
            Assert.AreEqual(475, books.GetPrice());
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
    }
}
