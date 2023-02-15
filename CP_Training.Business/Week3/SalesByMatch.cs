using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business.Week3
{
    public class SalesByMatch
    {
        public int sockMerchant(int n, List<int> ar)
        {
            ar.Sort();
            double division = 0;
            int result = 0;

            IEnumerable<List<int>> sublistas = ar.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.ToList());

            for (int i = 0; i < sublistas.Count(); i++)
            {
                division = sublistas.ElementAt(i).Count() / 2;
                result += Convert.ToInt32(Math.Round(division, 0));
            }

            return result;
        }
    }
}
