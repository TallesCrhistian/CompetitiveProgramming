using CP_Training.Business;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests
{
    public class BreakingTheRecordsTest
    {
        private BreakingTheRecords _breakingTheRecords;

        [SetUp]
        public void SetUp()
        {
            _breakingTheRecords = new BreakingTheRecords();
        }

        [Test]
        public void BreakingRecords_DetermineRecords_ArrayNumbersOfRecords()
        {
            List<int> expectedResult = new List<int>() { 4, 0 };

            List<int> scores = new List<int>() { 3, 4, 21, 36, 10, 28, 35, 5, 24, 42 };

            List<int> result = _breakingTheRecords.breakingRecords(scores);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
