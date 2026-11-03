public class Solution {
    public int SumOfDigits(int[] nums) {

        int n = nums.Length;
        int min = nums[0];

        for(int i = 0; i < n; i++)
        {
            if(nums[i] < min)
            {
                min = nums[i];
            }
        }

        int digitSum = 0; 
        while (min > 0)
        {
            digitSum += min % 10;
            min /= 10;
        }

        return (digitSum % 2 == 0) ? 1 : 0;

    }
}
