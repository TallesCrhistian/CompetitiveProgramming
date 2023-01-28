using CP_Training.Business;
using NUnit.Framework;

namespace CP_Training.UnitTests
{
    public class CamelCase4Test
    {
        private CamelCase4 _camelCase4;
        [SetUp]
        public void SetUp()
        {
            _camelCase4 = new CamelCase4();
        }

        [TestCase("S;M;plasticCup() ", "plastic cup")]
        [TestCase("C;V;mobile phone ", "mobilePhone")]
        [TestCase("C;C;coffee machine ", "CoffeeMachine")]
        [TestCase("S;C;LargeSoftwareBook ", "large software book")]
        [TestCase("C;M;white sheet of paper ", "whiteSheetOfPaper()")]
        [TestCase("S;V;pictureFrame ", "picture frame")]
        [TestCase("S;V;iPad ", "i pad")]
        [TestCase("C;M;mouse pad ", "mousePad()")]
        [TestCase("C;C;code swarm ", "CodeSwarm")]
        [TestCase("S;C;OrangeHighlighter ", "orange highlighter")]
        public void CamelCase_OperationString_ReturnStringFormated(string input, string expectedResult)
        {
            string result = _camelCase4.CamelCase(input);

            Assert.That(result == expectedResult);
        }
    }
}
