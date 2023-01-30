using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class LonelyInterger
    {
        public int lonelyinteger(List<int> a)
        {
            List<int> valuesKeys = new List<int>();
            int result = new int();
            a.Sort();

            Dictionary<int, int> numberCounts = new Dictionary<int, int>();

            foreach (int number in a)
            {
                if (numberCounts.ContainsKey(number))
                {
                    numberCounts[number]++;
                }
                else
                {
                    numberCounts[number] = 1;
                }
            }

            int i = 0;
            foreach (int value in numberCounts.Values)
            {
                if (value == 1)
                {
                    foreach (int key in numberCounts.Keys)
                    {
                        valuesKeys = numberCounts.Keys.ToList();
                        result = valuesKeys[i];
                    }
                }
                i++;
            }

            return result;
        }
    }
}
