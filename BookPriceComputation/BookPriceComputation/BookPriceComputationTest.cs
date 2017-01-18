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
    }
}
