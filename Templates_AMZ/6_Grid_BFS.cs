using System.Collections.Generic;

public class AmazonBfsBlueprint {
    public int SpreadTime(int[][] grid) {
        // 1. Guard Clause: Protect against empty arrays
        if (grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;

        int rows = grid.Length;
        int cols = grid[0].Length;
        
        Queue<int[]> queue = new Queue<int[]>();
        int targetItems = 0;

        // 2. Scan grid to locate initial source nodes and count targets
        for (int r = 0; r < rows; r++) {
            for (int c = 0; c < cols; c++) {
                if (grid[r][c] == 2) {
                    queue.Enqueue(new int[] { r, c }); // Enqueue starting sources
                } else if (grid[r][c] == 1) {
                    targetItems++; // Count elements that need to be changed
                }
            }
        }

        if (targetItems == 0) return 0;
        int timeElapsed = 0;

        // Direction matrix array to move Up, Down, Left, Right dynamically
        int[][] directions = new int[][] {
            new int[] {1, 0}, new int[] {-1, 0}, new int[] {0, 1}, new int[] {0, -1}
        };

        // 3. Process the queue level-by-level (Each loop iteration = 1 unit of time)
        while (queue.Count > 0 && targetItems > 0) {
            timeElapsed++;
            int currentLevelSize = queue.Count; // Freeze queue size for this step

            for (int i = 0; i < currentLevelSize; i++) {
                int[] current = queue.Dequeue();
                int currRow = current[0];
                int currCol = current[1];

                foreach (var dir in directions) {
                    int nextRow = currRow + dir[0];
                    int nextCol = currCol + dir[1];

                    // 4. Absolute Boundary Check (Identical constraints as DFS)
                    if (nextRow >= 0 && nextRow < rows && nextCol >= 0 && nextCol < cols && grid[nextRow][nextCol] == 1) {
                        grid[nextRow][nextCol] = 2; // Infect/process target node
                        targetItems--; // Reduce remaining targets
                        queue.Enqueue(new int[] { nextRow, nextCol }); // Add next wave source
                    }
                }
            }
        }

        // Return time total if all elements are reached, otherwise -1 (impossible grid block)
        return targetItems == 0 ? timeElapsed : -1;
    }
}
