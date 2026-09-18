using System.Collections.Generic;

public class AmazonBfsBlueprint {
    public int SpreadTime(int[][] grid)
    {
        if(grid == null || grid.Length == 0 || grid[0].Length == 0) return 0;

        int row = grid.Length;
        int cols = grid[0].Length;
        Queue<int[]> queue = new Queue<int[]>();
        int targetItems = 0; // counter for all the healthy

        for(int r = 0; r < row; r++)
        {
            for(int c = 0; c < cols; c++)
            {
                if(grid[r][c] == 2) // if we found infected then:
                {
                    queue.Enqueue(new int[] {r, c});
                }
                else if (grid[r][c] == 1)
                {
                    targetItems++; // count the ones that need to be changed
                }
            }
        }

        if (targetItems == 0) return 0;
        int timeElapsed = 0;

        int[][] directions = new int[][]
        {
            new int[]{1,0}, new int[]{-1,0}, new int[]{0,1}, new int[]{0, -1}
        };

        while(queue.Count > 0 && targetItems > 0)
        {
            timeElapsed++;
            int currentLevelSize = queue.Count; // Freeze queue size for this step

            for(int i = 0; i < currentLevelSize; i++)
            {
                int current = queue.Dequeue();
                int currRow = current[0];
                int currCol = current[1];
                
                foreach(var dir in directions)
                {
                    int nextRow = currentRow + dir[0];
                    int nextCol = currentCol + dir[1];

                    if(nextRow >= 0 && nextRow < rows && nextCol >= 0 && nextCol >= 0 && nextCol < cols && grid[nextRow][nextCol] == 1)
                    {
                        grid[nextRow][nextCol] = 2; // Infect target node
                        targetItems--; 
                        queue.Enqueue(new int[] {nextRow, nextCol});
                    }
                }
            }
        }
        return targetItems == 0 ? timeElapsed : -1;
    }
}
