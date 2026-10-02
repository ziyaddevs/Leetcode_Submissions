public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int l = 1;
        int r = 0;
        foreach (int pile in piles) {
            r = Math.Max(r, pile); // Find the max pile for our upper bound
        }

        int result = r;

        while (l <= r) {
            int k = l + (r - l) / 2; // Our guessed eating speed
            
            long totalHours = 0;
            foreach (int pile in piles) {
                // Ceiling division: (pile + k - 1) / k
                totalHours += (long)(pile + k - 1) / k;
            }

            // If she finishes within the allowed hours, it's a valid speed
            if (totalHours <= h) {
                result = k;    // Record it as a candidate
                r = k - 1;     // Try to find a smaller (slower) speed on the left
            } else {
                l = k + 1;     // Too slow, we need a faster speed on the right
            }
        }

        return result;
    }
}