using CP_Training.Business.Week3;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests.Week3Tests
{
    public class MaximumPerimeterTriangleTest
    {
        MaximumPerimeterTriangle _maximumPerimeterTriangle;

        [SetUp]
        public void SetUp()
        {
            _maximumPerimeterTriangle = new MaximumPerimeterTriangle();
        }

        [Test]
        public void MaximumPerimeterTriangle_FormTriangle_MaxAreaOfTriangle()
        {
            List<int> sticks = new List<int>() { 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000,
                1000000000, 1000000000,
                1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000, 1000000000 };
            List<int> expectedResult = new List<int>() { 1000000000, 1000000000, 1000000000 };

            List<int> result = _maximumPerimeterTriangle.maximumPerimeterTriangle(sticks);

            Assert.AreEqual(result, expectedResult);
        }
    }
}
