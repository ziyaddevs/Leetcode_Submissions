public class Solution {
    public int[][] KClosest(int[][] points, int k)
    {
        return points
        .OrderBy(p => (p[0] * p[0] + (p[1] * p[1]))) // Sort by squared distance
        .Take(k) // grab the top k closest
        .ToArray(); // conver back to a 2D array
    }
}
