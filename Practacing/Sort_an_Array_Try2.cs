public class Solution {
    public int[] SortArray(int[] nums) {
        if (nums.Length <= 1) return nums;
        
        MergeSort(nums, 0, nums.Length - 1);
        return nums;
    }

    private void MergeSort(int[] nums, int left, int right) {
        if (left >= right) return;

        int mid = left + (right - left) / 2;

        // 1. Recursively split the left half
        MergeSort(nums, left, mid);
        // 2. Recursively split the right half
        MergeSort(nums, mid + 1, right);
        // 3. Merge the sorted halves back together
        Merge(nums, left, mid, right);
    }

    private void Merge(int[] nums, int left, int mid, int right) {
        // Create a temporary array to hold merged elements
        int[] temp = new int[right - left + 1];
        int i = left;      // Pointer for left half
        int j = mid + 1;   // Pointer for right half
        int k = 0;         // Pointer for temp array

        // Compare elements from both halves and put the smaller one into temp
        while (i <= mid && j <= right) {
            if (nums[i] <= nums[j]) {
                temp[k++] = nums[i++];
            } else {
                temp[k++] = nums[j++];
            }
        }

        // Copy any remaining elements from the left half
        while (i <= mid) {
            temp[k++] = nums[i++];
        }

        // Copy any remaining elements from the right half
        while (j <= right) {
            temp[k++] = nums[j++];
        }

        // Copy the sorted temporary array back into the original nums array
        for (int p = 0; p < temp.Length; p++) {
            nums[left + p] = temp[p];
        }
    }
}