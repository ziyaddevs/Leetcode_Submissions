/** 
 * Forward declaration of guess API.
 * @param  num   your guess
 * @return 	     -1 if num is higher than the picked number
 *			      1 if num is lower than the picked number
 *               otherwise return 0
 * int guess(int num);
 */

public class Solution : GuessGame {
    public int GuessNumber(int n) {
        int l = 1;
        int r = n;
        while (l <= r)
        {
            
            int mid = l + (r - l) / 2;
            int result = guess(mid);

            if(result == 0)
            {
                return mid; // found it
            }
            else if(result == -1)
            {
                r = mid - 1; // search in the left half
            }
            else
            {
                l = mid + 1; // Our guess was too low, search the right half
            }
        }
        return -1; // not found
    }
}