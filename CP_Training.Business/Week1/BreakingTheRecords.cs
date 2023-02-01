using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business
{
    public class BreakingTheRecords
    {
        public List<int> breakingRecords(List<int> scores)
        {
            List<int> minPoints = new List<int>();
            List<int> maxPoints = new List<int>();            
            
            int baseRecordMax = scores[0];
            int baseRecordMin = scores[0];

            for (int i = 0; i < scores.Count; i++)
            {
               
                if (scores[i] < baseRecordMin)
                {
                    minPoints.Add(scores[i]);
                    baseRecordMin = scores[i];
                }

                else if (scores[i] > baseRecordMax)
                {
                    maxPoints.Add(scores[i]);
                    baseRecordMax = scores[i];
                }
            }

            minPoints = minPoints.Distinct().ToList();
            maxPoints = maxPoints.Distinct().ToList();

            List<int> records = new List<int>() { maxPoints.Count, minPoints.Count };

            return records;
        }
    }
}
