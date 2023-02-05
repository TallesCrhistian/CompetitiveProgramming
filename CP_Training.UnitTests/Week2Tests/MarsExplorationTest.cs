using CP_Training.Business.Week2;
using NUnit.Framework;

namespace CP_Training.UnitTests.Week2Tests
{
    public class MarsExplorationTest
    {
       private MarsExploration _marsExploration;

        [SetUp]
        public void SetUp()
        {
            _marsExploration = new MarsExploration();
        }

        [TestCase("SOSSPSSQSSOR", 3)]
        public void MarsExploration_RepairMessage(string s, int expectedResult)
        {
            int result = _marsExploration.marsExploration(s);

            Assert.That(result == expectedResult);
        }

    }
}
