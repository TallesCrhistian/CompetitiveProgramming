using System;
using System.Collections.Generic;

namespace CP_Training.Business.Week2
{
    public class DiagonalDifference
    {
        public int diagonalDifference(List<List<int>> arr)
        {
            List<int> diagonalOne = new List<int>();
            List<int> diagonalTwo = new List<int>();
            int indiceRevert = 0;
            int sunOne = 0;
            int sunTwo = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                diagonalOne.Add(arr[i][i]);
            }

            for (int i = arr.Count - 1; i >= 0; i--)
            {
                diagonalTwo.Add(arr[i][indiceRevert]);
                indiceRevert++;
            }

            foreach (int number in diagonalOne)
            {
                sunOne += number;
            }

            foreach (int number in diagonalTwo)
            {
                sunTwo += number;
            }

            int result = Math.Abs(sunOne - sunTwo);

            return result;
        }
    }
}
