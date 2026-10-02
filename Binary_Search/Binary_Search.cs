public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;

        while (l <= r)
        {
            // find the middle index
            int mid = l + (r - l) / 2;

            if(nums[mid] == target)
            {
                return mid; // Found it!
            }
            else if (nums[mid] < target)
            {
                l = mid + 1; // Search the right half
            }
            else
            {
                r = mid - 1; // Search the left half        
            }
        }
        return -1; // Not found
    }
}
