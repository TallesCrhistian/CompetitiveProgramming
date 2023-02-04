using System;

namespace CP_Training.Business
{
    public class FippingBits
    {
        public long flippingBits(long n)
        {
            string binary = "";
            int bits = 32;
            string newString = "";


            while (n > 0)
            {
                binary = (n % 2) + binary;
                n /= 2;
            }

            string resultSring = binary.PadLeft(bits, '0');

            for (int i = 0; i < resultSring.Length; i++)
            {
                if (resultSring[i] == '0')
                {
                    newString += '1';
                }
                else
                {
                    newString += '0';
                }
            }

            ulong decimalValue = Convert.ToUInt64(newString, 2);

            long result = (long)decimalValue;

            return (long)result;
        }
    }
}
