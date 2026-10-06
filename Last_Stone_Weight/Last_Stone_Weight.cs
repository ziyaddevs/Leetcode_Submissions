public class Solution {
    public int LastStoneWeight(int[] stones) {
        // Use a priority queue where priority is negated to act as a Max-Heap
        var maxHeap = new PriorityQueue<int, int>();

        foreach (int stone in stones) {
            maxHeap.Enqueue(stone, -stone);
        }

        while (maxHeap.Count > 1) {
            int stone1 = maxHeap.Dequeue();
            int stone2 = maxHeap.Dequeue();

            if (stone1 != stone2) {
                int remainder = Math.Abs(stone1 - stone2);
                maxHeap.Enqueue(remainder, -remainder);
            }
        }

        return maxHeap.Count > 0 ? maxHeap.Dequeue() : 0;
    }
}