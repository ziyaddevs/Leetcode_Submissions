public class Solution {
    public bool isConsecutive(int[] nums)
    {
        int n = nums.Length;

        if (n == 0){
            return false;
        }

        int min = nums[0];
        int max = nums[0];
        HashSet<int> set = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            if (set.Contains(nums[i]))
            {
                return false;
            }
            set.Add(nums[i]);
            min = Math.Min(min, nums[i]);
            max = Math.Max(max, nums[i]);
        }
        return (max - min + 1) == n;
    }
}
