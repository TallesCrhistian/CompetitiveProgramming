using System;
using System.Collections.Generic;

namespace CP_Training.Business
{
    public class PlusMinus
    {
        public List<decimal> plusMinus(List<int> arr)
        {
            List<decimal> result = new List<decimal>();
            List<int> positive = new List<int>();
            List<int> negative = new List<int>();
            List<int> zero = new List<int>();          

            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > 0) positive.Add(arr[i]);

                else if (arr[i] < 0) negative.Add(arr[i]);

                else zero.Add(arr[i]);
            }

            decimal positiveSize = positive.Count;
            decimal negativeSize = negative.Count;
            decimal zeroSize = zero.Count;
            decimal arrSize = arr.Count;

            decimal portionPositive = positiveSize / arrSize;
            decimal portionNegative = negativeSize / arrSize;
            decimal portionZero = zeroSize / arrSize;

            portionPositive = Math.Round(portionPositive, 6);
            portionNegative = Math.Round(portionNegative, 6);
            portionZero = Math.Round(portionZero, 6);

            result = new List<decimal>() { portionPositive, portionNegative, portionZero };


            return result;
        }
    }
}
