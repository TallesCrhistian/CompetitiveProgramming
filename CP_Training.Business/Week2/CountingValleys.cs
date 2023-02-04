namespace CP_Training.Business.Week2
{
    public class CountingValleys
    {
        public int countingValleys(int steps, string path)
        {            
            int result = 0;
            int coutStep = 0; 

            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == 'U') coutStep++;

                else coutStep--;

                if (coutStep == 0 && path[i] == 'U')
                {
                    result++;
                }
            }

            return result;
        }
    }
}
