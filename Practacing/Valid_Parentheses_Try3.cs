public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;

        Stack<char> stack = new Stack<char>();

        Dictionary<char, char> bracketMap = new Dictionary<char, char>()
        {
            {')', '('},
            {']', '['},
            {'}', '{'},
        };

        foreach(char c in s)
        {
            if(bracketMap.ContainsKey(c))
            {
                char topElement = stack.Count > 0 ? stack.Pop() : '#';

                if(topElement != bracketMap[c])
                {
                    return false;
                }
            }
            else
            {
                stack.Push(c);
            }
        }

        return stack.Count == 0;


    }
}
