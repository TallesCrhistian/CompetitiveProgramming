using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business.Week3
{
    public class SubarrayDivision2
    {
        public int birthday(List<int> s, int d, int m)
        {
            int ways = 0;

            for (int i = 0; i < s.Count - m + 1; i++)
            {
                int sum = 0;
                for (int j = i; j < i + m; j++)
                {
                    sum += s[j];
                }

                if (sum == d)
                {
                    ways++;
                }
            }

            return ways;
        }

    }
}

