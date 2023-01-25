using CP_Training.Business;
using NUnit.Framework;
using System.Collections.Generic;


namespace CP_Training.UnitTests
{
    public class Min_MaxSumTest
    {
        private Min_MaxSum _min_MaxSum;

        [SetUp]
        public void SetUp()
        {
            _min_MaxSum = new Min_MaxSum();
        }

        [Test]
        public void MiniMaxSum_CalculateMaxAndMinValue_PrintsMaxAndMin()
        {
            List<int> arr = new List<int> { 7, 69, 2, 221, 8974 };
            List<long> expectedResult = new List<long> { 299, 9271 };

            List<long> result = _min_MaxSum.miniMaxSum(arr);

            Assert.AreEqual(expectedResult, result);
        }

    }
}
