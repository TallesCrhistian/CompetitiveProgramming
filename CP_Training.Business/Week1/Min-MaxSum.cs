using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class Min_MaxSum
    {
        public List<long> miniMaxSum(List<int> arr)
        {
            long valueMin = new long();
            long valueMax = new long();

            arr.Sort();

            for (int i = 0; i < arr.Count - 1; i++)
            {
                valueMin += arr[i];
            }

            for (int i = 1; i < arr.Count; i++)
            {
                valueMax += arr[i];
            }

            List<long> resultFinaly = new List<long> { valueMin, valueMax };            

            return resultFinaly;
        }

    }
}
