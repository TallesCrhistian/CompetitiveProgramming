using System.Linq;

namespace CP_Training.Business.Week2
{
    public class Pangrams
    {
        public string pangrams(string s)
        {
            s = s.ToUpper();
            s = s.Replace(" ", string.Empty);
            string englishAlphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string result = "";

            for (int i = 0; i < englishAlphabet.Length; i++)
            {
                if (s.Contains(englishAlphabet[i]))
                {
                    result += englishAlphabet[i];
                }
            }

            if (result == englishAlphabet) return "pangram";

            else return "not pangram";
        }
    }
}
