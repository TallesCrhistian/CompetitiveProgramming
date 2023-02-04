using CP_Training.Business.Week2;
using NUnit.Framework;

namespace CP_Training.UnitTests.Week2Tests
{
    public class PangramsTest
    {
        private Pangrams _pangramsTest;

        [SetUp]
        public void SetUp()
        {
            _pangramsTest = new Pangrams();
        }

        [TestCase("We promptly judged antique ivory buckles for the next prize", "pangram", Description = "Contém todas letras do alfabeto US")]
        [TestCase("We promptly judged antique ivory buckles for the prize", "not pangram", Description = "Não contém todas letras do alfabeto US")]
        public void Pangrams_PangramasTrueorFalse(string s, string expectedResult)
        {
            string result = _pangramsTest.pangrams(s);

            Assert.That(expectedResult == result);
        }
    }
}
