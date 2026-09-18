using System.Collections.Generic;

public class AmazonFrequencyBlueprint {
    public int GetMostFrequentItem(int[] itemIDs) {
        // 1. Guard Clause: Handle bad arrays immediately
        if (itemIDs == null || itemIDs.Length == 0) return -1;

        // Dictionary Maps: <ItemID_Identifier, TotalCount>
        Dictionary<int, int> frequencyTracker = new Dictionary<int, int>();

        // 2. Populate frequency configuration values
        foreach (int id in itemIDs) {
            if (frequencyTracker.ContainsKey(id)) {
                frequencyTracker[id]++;
            } else {
                frequencyTracker[id] = 1;
            }
        }

        int targetItemIdentifier = -1;
        int highestRecordedFrequency = 0;

        // 3. Linear scan to pull peak activity profile
        foreach (var entry in frequencyTracker) {
            if (entry.Value > highestRecordedFrequency) {
                highestRecordedFrequency = entry.Value;
                targetItemIdentifier = entry.Key;
            }
        }
        return targetItemIdentifier;
    }
}
