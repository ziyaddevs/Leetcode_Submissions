public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        var result = new List<IList<int>>();
        Backtrack(nums, 0, new List<int>(), result);
        return result;
    }

    private void Backtrack(int[] nums, int start, List<int> current, IList<IList<int>> result) {
        // Every state in the recursion tree is a valid subset
        result.Add(new List<int>(current));

        for (int i = start; i < nums.Length; i++) {
            // Include the current element
            current.Add(nums[i]);
            
            // Recurse to the next index
            Backtrack(nums, i + 1, current, result);
            
            // Backtrack by removing the element
            current.RemoveAt(current.Count - 1);
        }
    }
}