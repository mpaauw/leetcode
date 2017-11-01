public class Solution
{
    private int n;
    private int m;
    private int[,] map;

    public int MaxAreaOfIsland(int[,] grid)
    {
        n = grid.GetLength(0);

        // edge cases:
        if (n < 1)
        {
            return 0;
        }

        m = grid.GetLength(1);

        map = grid;

        int maxArea = 0;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                if (grid[row, col] == 1)
                {
                    // land encountered, process landmass:
                    int area = findAreaBFS(new Tuple<int, int>(row, col), 0);
                    if (area > maxArea)
                    {
                        maxArea = area;
                    }
                }
            }
        }

        return maxArea;
    }

    private int findAreaBFS(Tuple<int, int> coords, int area)
    {
        int row = coords.Item1;
        int col = coords.Item2;
        if (row < 0 || row >= n || col < 0 || col >= m || map[row, col] == 0)
        {
            return area;
        }
        map[row, col] = 0; // mark land as visited
        area += 1;
        area = findAreaBFS(new Tuple<int, int>(row + 1, col), area);
        area = findAreaBFS(new Tuple<int, int>(row, col + 1), area);
        area = findAreaBFS(new Tuple<int, int>(row - 1, col), area);
        area = findAreaBFS(new Tuple<int, int>(row, col - 1), area);
        return area;
    }
}