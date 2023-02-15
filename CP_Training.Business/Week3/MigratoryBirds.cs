using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business.Week3
{
    public class MigratoryBirds
    {
        public int migratoryBirds(List<int> arr)
        {
            arr.Sort();
            int result;

            Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();

            foreach (int elem in arr)
            {
                if (dict.ContainsKey(elem))
                {
                    dict[elem].Add(elem);
                }
                else
                {
                    dict.Add(elem, new List<int> { elem });
                }
            }

            result = dict.Aggregate((l, r) => l.Value.Count >= r.Value.Count ? l : r).Key;

            return result;
        }
    }
}

