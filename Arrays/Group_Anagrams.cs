public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        Dictionary<string, List<string>> map = new Dictionary<string, List<string>>();

        foreach(string s in strs)
        {
            // 1. Sort the characters of the current word to create a signature key
            char[] charArray = s.ToCharArray();
            Array.Sort(charArray);
            string sortedKey = new string(charArray);

            // 2. If this sorted new key isnt in our dictionary, we give it a new list bucket
            if(!map.ContainsKey(sortedKey))
            {
                map[sortedKey] = new List<string>();
            }

            // 3. Drop the original word into its matching signature bucket
            map[sortedKey].Add(s);
        }

        // 4. Return all the grouped lists from our dictionary
        return new List<IList<string>>(map.Values);
        
        
    }
}
