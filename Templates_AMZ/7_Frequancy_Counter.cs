using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        // 1. Guard Clause: Protect against empty arrays or invalid K variables
        if (nums == null || nums.Length == 0 || k <= 0) {
            return new int[0];
        }

        // 2. Map Counter: Dictionary tracks <Item_ID, Frequency_Count>
        Dictionary<int, int> frequencyTracker = new Dictionary<int, int>();
        
        for (int i = 0; i < nums.Length; i++) {
            int currentNum = nums[i];
            if (frequencyTracker.ContainsKey(currentNum)) {
                frequencyTracker[currentNum]++;
            } else {
                frequencyTracker[currentNum] = 1;
            }
        }

        // 3. Fast LINQ Aggregation & Sorting
        // This sorts by the value (frequency) descending, extracts keys, and grabs the top K
        int[] result = frequencyTracker
            .OrderByDescending(entry => entry.Value)
            .Select(entry => entry.Key)
            .Take(k)
            .ToArray();

        return result;
    }
}
