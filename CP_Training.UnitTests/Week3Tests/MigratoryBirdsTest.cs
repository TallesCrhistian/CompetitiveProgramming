using CP_Training.Business.Week3;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests.Week3Tests
{
    public class MigratoryBirdsTest
    {
        MigratoryBirds _migratoryBirds;

        [SetUp]
        public void SetUp()
        {
            _migratoryBirds = new MigratoryBirds();
        }

        [Test]
        public void migratoryBirds_MostViewedSelectedIndex_Index()
        {
            List<int> arr = new List<int>() { 1, 2, 3, 4, 5, 4, 3, 2, 1, 3, 4 };
            int expectedResult = 3;

            int result = _migratoryBirds.migratoryBirds(arr);

            Assert.That(result == expectedResult);
        }

    }
}
