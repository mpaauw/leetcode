public class Solution
{
    public int MaxIncreaseKeepingSkyline(int[][] grid)
    {

        // for each cell:
        //  - get vertical / horizontal max
        //  - new value is the lesser of the vert / hori maxes
        //      - if both are equal, new value is resultant
        int numRows = (grid.Length > 0) ? grid.Length : throw new ArgumentException();
        int numCols = (grid[0].Length > 0) ? grid[0].Length : throw new ArgumentException();
        int totalSum = 0;

        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numCols; col++)
            {
                // get vert max:
                int vertMax = 0;
                for (int i = 0; i < numRows; i++)
                {
                    if (grid[i][col] > vertMax)
                    {
                        vertMax = grid[i][col];
                    }
                }

                // get hori max:
                int horiMax = 0;
                for (int i = 0; i < numCols; i++)
                {
                    if (grid[row][i] > horiMax)
                    {
                        horiMax = grid[row][i];
                    }
                }

                int newHeight = (vertMax <= horiMax) ? vertMax : horiMax;
                totalSum += newHeight - grid[row][col];
            }
        }
        return totalSum;
    }
}