using CP_Training.Business;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests
{
    public class SparseArraysTest
    {
        SpareArrays _spareArrays;

        [SetUp]
        public void SetUp()
        {
            _spareArrays = new SpareArrays();
        }

        [Test]
        public void matchingStings_StingOutput_MatrizResult()
        {
            List<string> strings = new List<string>() { "def", "de", "fgh" };
            List<string> consultas = new List<string>() { "de", "lmn", "fgh" };
            List<int> expectedResult = new List<int>() { 1, 0, 1 };

            List<int> result = _spareArrays.matchingStrings(strings, consultas);

            Assert.AreEqual(result, expectedResult);
        }

    }
}
