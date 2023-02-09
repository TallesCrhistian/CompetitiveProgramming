using CP_Training.Business.Week3;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests.Week3Tests
{
    public class SubarrayDivision2Test
    {
        SubarrayDivision2 _subarrayDivision2;

        [SetUp]
        public void SetUp()
        {
            _subarrayDivision2 = new SubarrayDivision2();
        }

        [Test]
        public void Birthday_sharedChocolate_DivisionWays()
        {
            List<int> s = new List<int>() { 2, 2, 1, 3, 2 };
            int d = 4;
            int m = 2;
            int expectedResult = 2;

            int result = _subarrayDivision2.birthday(s, d, m);

            Assert.That(result == expectedResult);
        }
    }
}
