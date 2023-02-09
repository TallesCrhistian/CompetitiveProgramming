using System;
using System.Collections.Generic;

namespace CP_Training.Business.Week2
{
    class FlippingTheMatrix
    {
        public int flippingMatrix(List<List<int>> matrix)
        {
            int rows = matrix.Count;
            int columns = matrix[0].Count;
            int maxSum = 0;

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;

                for (int j = 0; j < columns / 2; j++)
                {
                    rowSum += matrix[i][j] + matrix[i][columns - j - 1];
                }

                if (columns % 2 != 0)
                {
                    rowSum += matrix[i][columns / 2];
                }

                maxSum = Math.Max(maxSum, rowSum);
            }

            for (int j = 0; j < columns; j++)
            {
                int colSum = 0;

                for (int i = 0; i < rows / 2; i++)
                {
                    colSum += matrix[i][j] + matrix[rows - i - 1][j];
                }

                if (rows % 2 != 0)
                {
                    colSum += matrix[rows / 2][j];
                }

                maxSum = Math.Max(maxSum, colSum);
            }

            return maxSum;
        }
    }
}


