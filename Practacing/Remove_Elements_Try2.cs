public class Solution {
    public int RemoveElement(int[] nums, int val)
    {
       
        int k = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}

// int k = 0; // Our writer pointer (tracks valid elements)

        // // Loop through the array with our read pointer 'i'
        // for(int i = 0; i < nums.Length; i++)
        // {
        //     // if the current number is NOT the one we want to remove...
        //     if(num[i] != val)
        //     {
        //         nums[k] = nums[i]; // Copy it to our write spot
        //         k++; // move our write spot forward
        //     }
        // }

        // return k;