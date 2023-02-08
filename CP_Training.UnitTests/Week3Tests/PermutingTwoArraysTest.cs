using CP_Training.Business.Week3;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests.Week3Tests
{
    public class PermutingTwoArraysTest
    {
        private PermutingTwoArrays _permutingTwoArrays;

        [SetUp]
        public void SetUp()
        {
            _permutingTwoArrays = new PermutingTwoArrays();
        }

        [Test]
        public void TwoArrays_PermutationTwoArrays_ReturnYES()
        {
            List<int> A = new List<int> { 2, 1, 3 };
            List<int> B = new List<int> { 7, 8, 9 };
            int k = 10;
            string expectedResult = "YES";

            string result = _permutingTwoArrays.twoArrays(k, A, B);

            Assert.That(result == expectedResult);
        }

        public void TwoArrays_PermutationTwoArrays_ReturnNO()
        {
            List<int> A = new List<int> { 1, 2, 2, 1 };
            List<int> B = new List<int> { 3, 3, 3, 4 };
            int k = 5;
            string expectedResult = "NO";

            string result = _permutingTwoArrays.twoArrays(k, A, B);

            Assert.That(result == expectedResult);
        }
    }
}
