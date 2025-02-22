using System;

public class Solution
{
    public IList<int> SpiralOrder(int[][] matrix)
    {
        List<int> result = new List<int>();
        if (matrix.Length > 0)
        {
            int rowLength = matrix[0].Length - 1;
            int matrixLength = matrix.Length - 1;
            int top = 0;
            int left = 0;
            int maxElements = (matrixLength + 1) * (rowLength + 1);

            while (result.Count < maxElements)
            {
                for (int i = left; i <= rowLength && result.Count < maxElements; i++)
                {
                    result.Add(matrix[top][i]);
                }

                top++;

                for (int i = top; i <= matrixLength && result.Count < maxElements; i++)
                {
                    result.Add(matrix[i][rowLength]);
                }
                rowLength--;

                for (int i = rowLength; i >= left && result.Count < maxElements; i--)
                {
                    result.Add(matrix[matrixLength][i]);
                }
                matrixLength--;

                for (int i = matrixLength; i >= top && result.Count < maxElements; i--)
                {
                    result.Add(matrix[i][left]);
                }
                left++;
            }
        }
        return result;
    }
}