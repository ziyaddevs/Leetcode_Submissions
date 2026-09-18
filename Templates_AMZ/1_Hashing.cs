using System.Collections.Generic;

public class AmazonLookupBlueprint {
    public bool HasTargetPair(int[] items, int target) {
        // 1. Guard Clause: Protect against null or empty arrays
        if (items == null || items.Length < 2) return false;

        // 2. Create O(1) instant lookup memory storage
        HashSet<int> seenItems = new HashSet<int>();

        // 3. Scan the array exactly once linearly
        for (int i = 0; i < items.Length; i++) {
            int currentItem = items[i];
            int complement = target - currentItem; // The lookup condition

            // 4. Look backward instantly
            if (seenItems.Contains(complement)) {
                return true; // Match found!
            }

            // 5. Store current item for future calculations
            seenItems.Add(currentItem);
        }
        return false;
    }
}

