using System;
using System.Collections.Generic;

namespace CP_Training.Business.Week2
{
    public class GradingStudents
    {
        public List<int> gradingStudents(List<int> grades)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < grades.Count; i++)
            {
                if (grades[i] >= 38)
                {
                    int calc = grades[i] + (5 - grades[i] % 5) % 5;
                    if (Math.Abs(grades[i] - calc) < 3) result.Add(calc);

                    else result.Add(grades[i]);
                }
                else result.Add(grades[i]);
            }

            return result;
        }

    }
}
