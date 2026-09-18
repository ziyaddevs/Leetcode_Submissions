using System;
using System.Collections.Generic;

public class AmazonWindowBlueprint {
    public int LengthOfLongestSubstring(string s) {
        // 1. Guard Clause: Hand over empty string limits immediately
        if (string.IsNullOrEmpty(s)) return 0;

        // O(1) hash set tracking active characters inside the window
        HashSet<char> seenCharacters = new HashSet<char>();
        int left = 0;
        int maxWindowSize = 0;

        // 2. Expand the right boundary step-by-step
        for (int right = 0; right < s.Length; right++) {
            
            // 3. Duplicate hit! Evict characters from the left until the window is clean
            while (seenCharacters.Contains(s[right])) {
                seenCharacters.Remove(s[left]);
                left++; // Slide left index up
            }

            // 4. Safely add the current unique character to tracking
            seenCharacters.Add(s[right]);

            // 5. Update the peak continuous snapshot achieved (right - left + 1)
            maxWindowSize = Math.Max(maxWindowSize, right - left + 1);
        }
        return maxWindowSize;
    }
}
