public class Solution {
    public int[] TwoSum(int[] nums, int target)
    {
        int n = nums.Length;
        Dictionary<int,int> map = new Dictionary<int, int>();


        for(int i = 0; i < n; i++)
        {
            int complement = target - nums[i];

            if(map.ContainsKey(complement))
            {
                return new int[] {map[complement], i};
            }
            map[nums[i]] = i;
        }
        return new int[0];
    }
}
