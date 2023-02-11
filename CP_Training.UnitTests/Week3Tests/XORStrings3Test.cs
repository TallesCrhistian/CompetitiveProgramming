using CP_Training.Business.Week3;
using NUnit.Framework;

namespace CP_Training.UnitTests.Week3Tests
{
    public class XORStrings3Test
    {
        XORStrings3 _xORStrings3;

        [SetUp]
        public void SetUp()
        {
            _xORStrings3 = new XORStrings3();
        }

        [Test]
        public void XORStrings3Metods_XORbetweenStrings()
        {
            string one = "10101";
            string two = "00101";
            string expectedResult = "10000";

            string result = _xORStrings3.XORStrings3Metods(one, two);

            Assert.That(result == expectedResult);
        }
    }
}
