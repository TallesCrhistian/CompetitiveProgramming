using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class DividibleSumPairs
    {
        public int divisibleSumPairs(int n, int k, List<int> ar)
        {                        
            List<int> resultSoma = new List<int>();
            List<int> resultFinally = new List<int>();
            ar.Sort();

            List<Tuple<int, int>> pairs = new List<Tuple<int, int>>();

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <n; j++)
                {
                    pairs.Add(new Tuple<int, int>(ar[i], ar[j]));
                }
            }
            

            for (int i = 0; i < pairs.Count; i++)
            {
                resultSoma.Add(pairs[i].Item1 + pairs[i].Item2);
            }

            for (int i = 0; i < resultSoma.Count; i++)
            {
                if (resultSoma[i] % k == 0)
                {
                    resultFinally.Add(resultSoma[i]);
                }
            }

            return resultFinally.Count;
        }
    }
}
