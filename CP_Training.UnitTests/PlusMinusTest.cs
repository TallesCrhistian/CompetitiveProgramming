using CP_Training.Business;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests
{
    public class PlusMinusTest
    {
        private PlusMinus _plusMinus;

        [SetUp]
        public void Setup()
        {
            _plusMinus = new PlusMinus();
        }

        [Test]
        public void PulzMinus_CalculatesTheProportionsOfTheElements_PrintTheDecimalValue()
        {
            List<int> arr = new List<int> { -4, 3, -9, 0, 4, 1 };
            List<decimal> expectedResult = new List<decimal> { 0.5M, 0.333333M, 0.166667M };

           List<decimal> result =  _plusMinus.plusMinus(arr); 

            Assert.AreEqual(expectedResult, result);
        }
    }
}