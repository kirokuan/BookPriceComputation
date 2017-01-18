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
                new Book()
            };
            Assert.AreEqual(100, books.GetPrice());
        }

        [Test]
        public void Buy2Book()
        {
            var books = new List<Book>()
            {
                new Book(),new Book()
            };
            Assert.AreEqual(200, books.GetPrice());
        }
    }
}
