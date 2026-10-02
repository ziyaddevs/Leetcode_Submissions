public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;
        
        int l = 0;
        int r = (m * n) - 1; // Total number of elements minus 1

        while (l <= r) {
            int mid = l + (r - l) / 2;
            
            // Map 1D index back to 2D matrix coordinates
            int row = mid / n;
            int col = mid % n;
            int val = matrix[row][col];

            if (val == target) {
                return true;
            } 
            else if (val < target) {
                l = mid + 1; // Target is bigger, move right
            } 
            else {
                r = mid - 1; // Target is smaller, move left
            }
        }

        return false;
    }
}