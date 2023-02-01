using System;
using System.Globalization;


namespace CP_Training.Business
{
    public class TimeConversion
    {
        public string timeConversion(string s)
        {
            string timeConversion24 = "";
            DateTime dataOut;

            if (DateTime.TryParseExact(s, "hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataOut))
            {
                timeConversion24 = dataOut.ToString("HH:mm:ss");
            }

            return timeConversion24;
        }
    }
}