using System;
using System.Collections.Generic;

public class AmazonIntervalBlueprint {
    public int[][] Merge(int[][] intervals) {
        // 1. Guard Clause: 0 or 1 blocks require zero overlapping evaluation
        if (intervals == null || intervals.Length <= 1) return intervals;

        // 2. Sort the array blocks chronologically based on their Start coordinate (Index 0)
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> mergedResult = new List<int[]>();
        
        // Track the first window block as our baseline starting target
        int[] activeInterval = intervals[0];
        mergedResult.Add(activeInterval);

        // 3. Stream through the remaining timeline segments
        for (int i = 1; i < intervals.Length; i++) {
            int[] nextInterval = intervals[i];

            // 4. Overlap Condition: Next Start time happens before/at Active End time
            if (nextInterval[0] <= activeInterval[1]) {
                // Stretch the active window limit out to capture the furthest point
                activeInterval[1] = Math.Max(activeInterval[1], nextInterval[1]);
            } else {
                // 5. Gap detected! Commit a brand new separate active frame
                activeInterval = nextInterval;
                mergedResult.Add(activeInterval);
            }
        }
        
        // Convert the dynamic storage list cleanly back into a 2D jagged output array
        return mergedResult.ToArray();
    }
}
