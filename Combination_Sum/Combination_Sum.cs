public class Solution {
    public List<List<int>> CombinationSum(int[] nums, int target) {
        var result = new List<List<int>>();
        Backtrack(nums, target, 0, new List<int>(), result);
        return result;
    }

    private void Backtrack(int[] nums, int target, int start, List<int> current, List<List<int>> result) {
        if (target == 0) {
            result.Add(new List<int>(current));
            return;
        }

        if (target < 0) {
            return;
        }

        for (int i = start; i < nums.Length; i++) {
            // Include the number
            current.Add(nums[i]);
            
            // Recurse with 'i' (since elements can be reused) and reduced target
            Backtrack(nums, target - nums[i], i, current, result);
            
            // Backtrack by removing the last element
            current.RemoveAt(current.Count - 1);
        }
    }
}