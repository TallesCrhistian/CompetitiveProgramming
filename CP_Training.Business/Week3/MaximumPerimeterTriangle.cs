using System;
using System.Collections.Generic;
using System.Linq;

namespace CP_Training.Business.Week3
{
    public class MaximumPerimeterTriangle
    {
        public List<int> maximumPerimeterTriangle(List<int> sticks)
        {
            sticks.Sort();
            List<int> triagles = new List<int>();
            List<int> resultFalse = new List<int>();
            List<int> resultTrue = new List<int>();

            for (int a = 0; a < sticks.Count - 2; a++)
            {
                for (int b = a + 1; b < sticks.Count - 1; b++)
                {
                    for (int c = b + 1; c < sticks.Count; c++)
                    {
                        bool validateTriangle = ValidateTriangle(sticks[a], sticks[b], sticks[c]);

                        if (validateTriangle)
                        {
                            if (sticks[a] != sticks[b])
                            {
                                int area = CalculateArea(sticks[2], sticks[0], sticks[1]);

                                if (area >= 0)
                                {
                                    triagles.Add(sticks[a]);
                                    triagles.Add(sticks[b]);
                                    triagles.Add(sticks[c]);
                                }

                                else
                                {
                                    resultFalse.Add(-1);
                                }
                            }
                            else if (sticks[a] == sticks[b])
                            {
                                int area = CalculateArea(sticks[0], sticks[1], sticks[2]);

                                if (area >= 0)
                                {
                                    triagles.Add(sticks[a]);
                                    triagles.Add(sticks[b]);
                                    triagles.Add(sticks[c]);
                                }

                                else
                                {
                                    resultFalse.Add(-1);
                                }
                            }
                        }

                        else
                        {
                            resultFalse.Add(-1);
                        }
                    }
                }
            }

            if (triagles.Count <= 0)
            {
                resultFalse.Clear();
                resultFalse.Add(-1);



                return resultFalse;
            }

            resultTrue = triagles.GetRange(triagles.Count - 3, 3);

            resultTrue.Sort();

            return resultTrue;
        }

        public bool ValidateTriangle(int a, int b, int c)
        {
            if (a + b > c)
            {
                if (a + c > b)
                {
                    if (b + c > a)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public int CalculateArea(int baseTriangle, int adjacent, int hypotenuse)
        {
            if (baseTriangle > 100)
            {
                baseTriangle = baseTriangle / 100;
                adjacent = adjacent / 100;
                hypotenuse = hypotenuse / 100;
            }

            decimal height = (baseTriangle * adjacent) / hypotenuse;
            decimal area = (baseTriangle * height) / 2;

            return (int)area;
        }
    }
}
