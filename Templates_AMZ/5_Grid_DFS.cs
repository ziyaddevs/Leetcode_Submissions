public class AmazonDfsBlueprint {
    public int CountClusters(int[][] grid) {
        // 1. Guard Clause: Protect against empty arrays
        if (grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;

        int rows = grid.Length;
        int cols = grid[0].Length;
        int count = 0;

        // 2. Scan every cell in the matrix
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == 1) { // Found a starting target node
                    count++;
                    DfsSearch(grid, r, c, rows, cols); // Clear the cluster recursively
                }
            }
        }
        return count;
    }

    private void DfsSearch(int[][] grid, int r, int c, int rows, int cols) {
        // 3. Absolute Boundary Check (Prevents IndexOutOfRangeException)
        if (r < 0 || r >= rows || c < 0 || c >= cols || grid[r][c] != 1) {
            return;
        }

        // 4. Mark Cell as Visited (Prevents infinite loop/StackOverflow)
        grid[r][c] = 0; 

        // 5. Dive Deep in 4 directions
        DfsSearch(grid, r + 1, c, rows, cols); // Down
        DfsSearch(grid, r - 1, c, rows, cols); // Up
        DfsSearch(grid, r, c + 1, rows, cols); // Right
        DfsSearch(grid, r, c - 1, rows, cols); // Left
    }
}
