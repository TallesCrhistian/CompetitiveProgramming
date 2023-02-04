using CP_Training.Business.Week2;
using NUnit.Framework;

namespace CP_Training.UnitTests.Week2Tests
{
    public class CountingValleysTest
    {
        CountingValleys _countingValleys;

        [SetUp]
        public void SetUp()
        {
            _countingValleys = new CountingValleys();
        }

        [Test]
        public void CountingValleys_CoutSteps()
        {
            int steps = 12;
            string path = "DDUUDDUDUUUD";
            int expectedResult = 2;

            int result = _countingValleys.countingValleys(steps, path);

            Assert.That(result == expectedResult);
        }
    }
}
