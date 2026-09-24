public class Solution {
    public bool IsValid(string s) {
        int n = s.Length;
        Stack<char> stack = new Stack<char>();
        foreach (char c in s)
        {
            if(c == '(' || c == '{' || c == '[')
            {
             stack.Push(c);   
            }
            else
            {
                if (stack.Count == 0)
                {
                    return false;
                }

            // Pop the last opening bracket
            char lastOpen = stack.Pop();

            if (c == ')' && lastOpen != '(') return false;
            if (c == '}' && lastOpen != '{') return false;
            if (c == ']' && lastOpen != '[') return false;
            }
        }
        return stack.Count == 0;
    }
}
