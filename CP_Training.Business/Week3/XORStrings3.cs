using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP_Training.Business.Week3
{
    public class XORStrings3
    {
        public string XORStrings3Metods(string one, string two)
        {
            string result = string.Empty;

            for (int i = 0; i < one.Length; i++)
            {
                if (one[i] != two[i])
                {
                    result += "1";
                }
                else result += "0";
            }

            return result;
        }
    }
}
