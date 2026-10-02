public class Solution {
    public int ClimbStairs(int n) 
    {
        // If there are 1 or 2 steps, the answers are just 1 and 2     
        if (n <= 2) return n;

        int prev2 = 1; // Ways to reach step 1
        int prev1 = 2; // ways to reach step 2
        int current = 0;


        // Build up to n like the Fibonacci sequance
        for (int i = 3; i <= n; i++)
        {
            current = prev1 + prev2; // Add the last two steps together
            prev2 = prev1; // Shift forward
            prev1 = current; // Shift forward
        }
        
        return current;

    }
}
