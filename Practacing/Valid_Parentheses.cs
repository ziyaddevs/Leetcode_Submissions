public class Solution {
    public bool IsValid(string s) {
        if (s.Length % 2 != 0) return false;

        Stack<char> stack = new Stack<char>();

        // Dictionary name matches what we use below
        Dictionary<char, char> bracketMap = new Dictionary<char, char>()
        {
            {')', '('},
            {']', '['},
            {'}', '{'},
        };

        foreach (char c in s)
        {
            // If it's a closing bracket
            if (bracketMap.ContainsKey(c))
            {
                // Fixed ternary check: if stack is NOT empty, pop it. Otherwise use '#'
                char topElement = stack.Count > 0 ? stack.Pop() : '#';

                // If the popped opening bracket doesn't match the expected pair, it's invalid
                if (topElement != bracketMap[c])
                {
                    return false;
                }
                // Removed the incorrect 'else { stack.Push(c); }' 
            }
            else
            {
                // If it's an opening bracket, push it onto the stack
                stack.Push(c);
            }
        }

        // Moved outside the loop: returns true only if all brackets were matched/popped
        return stack.Count == 0;
    }
}