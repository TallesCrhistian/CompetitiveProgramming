using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CP_Training.Business
{
    public class CamelCase4
    {
        public string CamelCase(string input)
        {
            //while (true)
            //{
            // string input = Console.ReadLine();
            // if(input != null)

            List<string> listString = new List<string>();
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            string[] _split = input.Split(";");
            string result = "";

            if (_split[0] == "C")
            {
                for (int i = 2; i < _split.Length; i++)
                {
                    listString.Add(ti.ToTitleCase(_split[i]));
                }

                if (_split[1] == "M")
                {
                    result = String.Join(" ", listString);
                    string[] resultArray = result.Split(" ");
                    resultArray[0] = resultArray[0].ToLower();
                    result = String.Join(" ", resultArray);
                    result = result.Replace(" ", "");
                    result = result + "()";
                    Console.WriteLine(result);
                }

                else if (_split[1] == "V")
                {
                    result = String.Concat(listString);
                    string[] resultArray = result.Split(" ");
                    resultArray[0] = resultArray[0].ToLower();
                    result = String.Concat(resultArray);
                    result = result.Replace(" ", "");
                }

                else
                {
                    result = String.Join(" ", listString);
                    result = result.Replace(" ", "");
                }
            }

            else
            {

                for (int i = 2; i < _split.Length; i++)
                {
                    listString.Add(_split[i]);
                }

                string[] convertChar = Regex.Split(listString[0], "(?<!^)(?=[A-Z])");
                result = String.Join(" ", convertChar);
                result = result.ToLower();
                convertChar = result.Split("()");
                result = String.Join(" ", convertChar[0]);
                result = result.TrimEnd();
            }

            return result;

            //if (string.isnullorwhitespace)
            //{
            //    break;
            //}
            //}
            //}          

        }
    }
}
