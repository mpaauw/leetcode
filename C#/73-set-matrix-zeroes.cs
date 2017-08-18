public class Solution
{
    public void SetZeroes(int[,] matrix)
    {
        int numRows = matrix.GetLength(0);
        int numCols = matrix.GetLength(1);
        bool[] rowsToMark = new bool[numRows];
        bool[] colsToMark = new bool[numCols];

        for (int row = 0; row < numRows; row++) // scan all zero locations within matrix
        {
            for (int col = 0; col < numCols; col++)
            {
                if (matrix[row, col] == 0)
                {
                    rowsToMark[row] = true;
                    colsToMark[col] = true;
                }
            }
        }

        for (int i = 0; i < rowsToMark.Length; i++) // zero-out all relevant rows
        {
            if (rowsToMark[i])
            {
                for (int x = 0; x < numCols; x++)
                {
                    matrix[i, x] = 0;
                }
            }
        }

        for (int i = 0; i < colsToMark.Length; i++) // zero-out all relevant columns
        {
            if (colsToMark[i])
            {
                for (int x = 0; x < numRows; x++)
                {
                    matrix[x, i] = 0;
                }
            }
        }
    }
}