public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums)
    {
        int currentCount = 0;
        int maxCount = 0;

        foreach(int num in nums)
        {
            if(num == 1)
            {
                currentCount++;
                if(currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 0;
            }
        }
        return maxCount;
    }
}