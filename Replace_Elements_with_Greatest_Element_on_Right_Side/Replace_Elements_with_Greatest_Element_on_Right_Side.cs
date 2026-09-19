public class Solution {
    public int[] ReplaceElements(int[] arr) {
        int maxFromRight = -1;

        // Start at the last index and loop down to 0
        for(int i = arr.Length - 1; i >= 0; i--)
        {
            // 1. Save the current number before we overwrite it
            int temp = arr[i];

            // 2. Replace the current element with the max from the right.
            arr[i] = maxFromRight;

            // 3. Update maxFromRight to be the larger of the two (the old max or our saved original number)
            maxFromRight = Math.Max(maxFromRight, temp);
        }


        return arr;
    }
}