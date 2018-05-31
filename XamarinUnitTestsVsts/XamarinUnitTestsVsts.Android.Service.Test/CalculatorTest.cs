using System;
using NUnit.Framework;

namespace XamarinUnitTestsVsts.Android.Service.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void Add_Test()
        {
            var calc = new Calculator();
            Assert.AreEqual(3, calc.Add(1, 2));
        }

        [Test]
        public void Subtract_Test()
        {
            var calc = new Calculator();
            Assert.AreEqual(-1, calc.Subtract(1, 2));
        }

        [Test]
        public void Multiply_Test()
        {
            var calc = new Calculator();
            Assert.AreEqual(22, calc.Subtract(11, 2));
        }

        [Test]
        public void Divide_Test()
        {
            var calc = new Calculator();
            Assert.AreEqual(11, calc.Subtract(33, 3));
        }

        [Test]
        [Ignore("another time")]
        public void Ignore()
        {
            Assert.True(false);
        }
    }
}