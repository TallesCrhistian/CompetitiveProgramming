using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class SpareArrays
    {
        public List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            int[] arrayValues = new int[queries.Count];

            List<int> resultValues = new List<int>();

            for (int q = 0; q < queries.Count; q++)
            {
                for (int i = 0; i < strings.Count; i++)
                {
                    if (queries[q].Equals(strings[i]))
                    {
                        arrayValues[q]++;
                    }
                }
            }

            resultValues = arrayValues.ToList();

            return resultValues;
        }

    }
}
