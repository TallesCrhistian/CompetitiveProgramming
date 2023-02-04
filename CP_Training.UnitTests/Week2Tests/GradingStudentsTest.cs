using CP_Training.Business.Week2;
using NUnit.Framework;
using System.Collections.Generic;

namespace CP_Training.UnitTests.Week2Tests
{
    public class GradingStudentsTest
    {
        private GradingStudents _gradingStudents;

        [SetUp]
        public void SetUp()
        {
            _gradingStudents = new GradingStudents();
        }

        [Test]
        public void GradingStudents_RateGrade_RoundNote()
        {
            List<int> grades = new List<int>() { 84, 29, 57 };
            List<int> expectedResult = new List<int>() { 85, 29, 57 };

            List<int> result = _gradingStudents.gradingStudents(grades);

            CollectionAssert.AreEqual(result, expectedResult);
        }
    }
}
