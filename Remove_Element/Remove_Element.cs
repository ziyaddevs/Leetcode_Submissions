public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        foreach(int num in nums)
        {
            if(num != val)
            {
                nums[k] = num;
                k++;
            }
        }
        return k;
    }
}