using CP_Training.Business.Week2;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests.Week2Tests
{
    public class DiagonalDifferenceTest
    {
        DiagonalDifference _diagonalDifference;

        [SetUp]
        public void SetUp()
        {
            _diagonalDifference = new DiagonalDifference();
        }

        [Test]
        public void DiagonalDifference_DifferenceOfDiagonalSums_AbsoluteDifferenceDiagonals()
        {
            List<int> valuesRow1 = new List<int>() { 11, 2, 4 };
            List<int> valuesRow2 = new List<int>() { 4, 5, 6 };
            List<int> valuesRow3 = new List<int>() { 10, 8, -12 };
            List<List<int>> arr = new List<List<int>>() { valuesRow1, valuesRow2, valuesRow3 };
            int expectedResult = 15;

            int result = _diagonalDifference.diagonalDifference(arr);

            Assert.That(result == expectedResult);
        }
    }
}
