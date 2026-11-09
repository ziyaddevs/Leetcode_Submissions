public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length) return false;

        Dictionary<char, int> Counter = new Dictionary<char, int>();

        foreach (char c in s)
        {
            if (Counter.ContainsKey(c))
            {
                Counter[c]++;
            }
            else
            {
                Counter[c] = 1;
            }
        }

        foreach( char c in t)
        {
            if(!Counter.ContainsKey(c) || Counter[c] == 0)
            {
                return false;
            }
            else
            {
                Counter[c]--;
            }
        }
        return true;

    }
}
