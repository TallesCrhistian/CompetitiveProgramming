using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business.Week3
{
    public class PermutingTwoArrays
    {
        public string twoArrays(int k, List<int> A, List<int> B)
        {           
            A.Sort();
            B.Sort();
            int n = A.Count;

            for (int i = 0; i < n; i++)
            {
                if (A[i] + B[n - i - 1] < k)
                {
                    return "NO";
                }
            }

            return "YES";
        }
    }
}
