public class Solution {
    public bool hasDuplicate(int[] nums)
    {
        if (nums.Length == 0) return false;

        HashSet<int> seen = new HashSet<int>();

        foreach(int num in nums)
        {
            if(!seen.Contains(num))
            {
                seen.Add(num);
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}