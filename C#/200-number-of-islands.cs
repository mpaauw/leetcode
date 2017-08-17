public class Solution {

    private int numRows = 0;
    private int numCols = 0;

    public int NumIslands(char[,] grid) {
        int numIslands = 0;
        this.numRows = grid.GetLength(0);
        this.numCols = grid.GetLength(1);

        for(int row = 0; row < numRows; row++) {
            for(int col = 0; col < numCols; col++) {
                if(grid[row, col] == 1) {
                    explore(grid, row, col);
                    numIslands += 1;
                }
            }
        }
        return numIslands;
    }

    private void explore(char[,] grid, int row, int col) { // recursively mark rest of island in order to avoid in future explorations
        if((row < 0 || row > this.numRows) || (col < 0 || col > this.numCols) || (grid[row, col] != '1')) { // base case
            return;
        }
        grid[row, col] = 'X';
        explore(grid, row - 1, col);
        explore(grid, row + 1, col);
        explore(grid, row, col - 1);
        explore(grid, row, col + 1);
    }
}