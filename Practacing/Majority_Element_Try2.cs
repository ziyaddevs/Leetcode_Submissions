


public class Solution {
    public int MajorityElement(int[] nums)
    {
        Dictionary<int, int> count = new Dictionary<int, int>();
        int n = nums.Length;


        foreach(int num in nums)
        {
            if(!count.ContainsKey(num))
            {
                count[num] = 0;
            }
            count[num]++;


            if(count[num] > n / 2)
            {
                return num;
            }
        }
        return -1;
    }
}







        // Dictionary<int,int> counts = new Dictionary<int, int>();
        // int n = nums.Length;

        // foreach(int num in nums)
        // {
        //     // 1. if we havent seen this number yet, start its count at 0
        //     if(!counts.ContainsKey(num))
        //     {
        //         counts[num] = 0;
        //     }
        //     // 2. Increment its count
        //     counts[num]++;

        //     // 3. check if it crossed the majority threshhold (more than n/2 times)
        //     if(counts[num] > n / 2)
        //     {
        //         return num;
        //     }
        // }
        // return -1; // Fallback