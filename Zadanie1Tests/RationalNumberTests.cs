using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zadanie1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie1.Tests
{
    [TestClass()]
    public class RationalNumberTests
    {
        [TestMethod()]
        public void ToStringTest()
        {
            RationalNumber rational1 = new RationalNumber(5, 2);
            RationalNumber rational2 = new RationalNumber(1, 4);
            Assert.IsTrue( rational1 != rational2 );
        }

        [TestMethod()]
        public void Check()
        {
            RationalNumber rational1 = new RationalNumber(5, 2);
            RationalNumber rational2 = new RationalNumber(1, 4);
            Assert.IsTrue(rational1 > rational2);
        }
    }
}