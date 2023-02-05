using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business.Week2
{
    public class MarsExploration
    {
        public int marsExploration(string s)
        {
            int chunkCount = (int)Math.Ceiling((double)s.Length / 3);
            string[] result = new string[chunkCount];
            string baseString = "SOS";
            int resultInt = 0;

            for (int i = 0; i < s.Length; i += 3)
            {
                result[i / 3] = new string(s.Skip(i).Take(3).ToArray());
            }

            for (int i = 0; i < result.Length; i++)
            {
                for (int e = 0; e < baseString.Length; e++)
                {
                    if (result[i][e] != baseString[e])
                    {
                        resultInt++;
                    }
                }
            }

            return resultInt;
        }
    }
}

