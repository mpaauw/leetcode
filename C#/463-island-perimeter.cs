public class Solution {
    public int IslandPerimeter(int[,] grid) {
        // iterate through each cell in the grid
        // - if cell contains land, check all surrounding cells to see which are borders, water, or land.
        // - only count sides of a land cell that touch a border or water cell

        int perimeter = 0;

        int height = grid.GetLength(0);
        int width = grid.GetLength(1);
        for(int row = 0; row < height; row++) {
            for(int col = 0; col < width; col++) {
                int tile = grid[row, col];
                if(tile == 1) {
                    // check left
                    if(col > 0) {
                        if(grid[row, col - 1] == 0) {
                            perimeter += 1;
                        }
                    }
                    else {
                        perimeter += 1;
                    }
                    // check up
                    if(row > 0) {
                        if(grid[row - 1, col] == 0) {
                            perimeter += 1;
                        }
                    }
                    else {
                        perimeter += 1;
                    }
                    // check right
                    if(col < width - 1) {
                        if(grid[row, col + 1] == 0) {
                            perimeter += 1;
                        }
                    }
                    else {
                        perimeter += 1;
                    }
                    // check down
                    if(row < height - 1) {
                        if(grid[row + 1, col] == 0) {
                            perimeter += 1;
                        }
                    }
                    else {
                        perimeter += 1;
                    }
                }
            }
        }

        return perimeter;
    }
}