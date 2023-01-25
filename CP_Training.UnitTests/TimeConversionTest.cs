using CP_Training.Business;
using NUnit.Framework;
using System;

namespace CP_Training.UnitTests
{
    public class TimeConversionTest
    {
        private TimeConversion _timeConversion;

        [SetUp]
        public void SetUp()
        {
            _timeConversion = new TimeConversion();
        }

        [TestCase("07:05:45 AM", "07:05:45")]
        [TestCase("07:05:45 PM", "19:05:45")]
        public void TimeConversion_Conversion12For24_ReturnConversion24(string dateTime, string expectedResult)
        {
            string result = _timeConversion.timeConversion(dateTime);

            Assert.AreEqual(expectedResult, result);
        }
    }
}
