using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business.Week2
{
    public class CountingSort1
    {
        public List<int> countingSort(List<int> arr)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                result.Add(arr.Count(x => x == i));
            }

            return result;
        }
    }
}
