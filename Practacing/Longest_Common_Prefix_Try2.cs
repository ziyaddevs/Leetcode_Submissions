public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if( strs == null || strs.Length == 0) return "";

        // Start by assuming the first string is the common prefix
        string prefix = strs[0];

        // Compare prefix aginst every other string in the array
        for(int i = 1; i < strs.Length; i++)
        {
            // Shrink prefix from the end until strs[i] starts with it
            while(strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                // If prefix shrinks to empty string, there is no common prefix
                if(prefix.Length == 0) return "";
            }
        }
        return prefix;
        
    }
}