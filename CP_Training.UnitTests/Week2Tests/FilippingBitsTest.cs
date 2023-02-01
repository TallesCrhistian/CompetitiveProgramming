using CP_Training.Business;
using NUnit.Framework;

namespace CP_Training.UnitTests.Week2Tests
{
    public class FilippingBitsTest
    {
        FippingBits _fippingBits;

        [SetUp]
        public void SetUp()
        {
            _fippingBits = new FippingBits();
        }

        [Test]
        public void FlippingBits_InvertBits_IntAbsolut()
        {
            long n = 9;
            long expectedResult = 4294967286;

            long result = _fippingBits.flippingBits(n);

            Assert.That(result == expectedResult);
        }

    }
}
