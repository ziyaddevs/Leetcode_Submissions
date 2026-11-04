public class Solution {
    public int RemoveElement(int[] nums, int val) {
        if (nums.Length == 0 || nums.Length == null) return 0;
        
        int count = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[count] = nums[i];
                count++;
            }
        }
        return count;
    }

}