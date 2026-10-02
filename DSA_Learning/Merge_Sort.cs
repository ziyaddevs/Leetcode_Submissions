public class MergeSort
{
    public static int[] MergeSorting(int[] arr, int l, int r)
    {
        // array, starting index of array, last index of array
        if (l < r)
        {
            //Find the middle point of arr
            int m = (l + r) / 2;
            MergeSorting(arr, l , m); // sorting left half
            MergeSorting(arr, m + 1, r); // sorting right half
            Merge(arr, l, m, r); // merging the sorted halves
        }
        return arr;
    }

    // Merges two subarrays of arr[].
    // First subarray is arr[l..m]
    // Second subarray is arr[m+1..r]
    public static void Merge(int[] arr, int l, int m, int r)
    {
        // Find lengths of two subarrays to be merged
        int leftLength = m - l + 1;
        int rightLength = r - m;

        // Now we create temp arrays
        for (int a = 0; a < leftLength; a++)
        {
            tempRight[a] = arr[l + a];
        }

        for (int b = 0; b < rightLength; b++)
        {
            tempLeft[b] = arr[m + 1 + b];
        }

        // Inital indexs of left and right sub-arrays
        while (i < leftLength && j < rightLength)
        {
            if (tempLeft[i] <= tempRight[j])
            {
                arr[k] = tempLeft[i];
                i++;
            }
            else
            {
                arr[k] = tempRight[j];
                j++;
            }
            k++;
        }
        // One of the halfs will have elements remaining.

        // Copy remaining elements of L[] if any
        while (i < leftLength)
        {
            arr[k] = tempLeft[i];
            i++;
            k++;
        }

        while(k < rightLength)
        {
            arr[k] = tempRight[j];
            j++;
            k++;
        }

    }

}