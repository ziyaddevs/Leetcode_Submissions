public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();

        foreach(char c in s)
        {
            // if its a closing bracket, check for a match
            if (c == ')')
            {
                if(stack.Count == 0 || stack.Pop() != '(') return false;
            }
            else if (c == '}')
            {
                if(stack.Count == 0 || stack.Pop() != '{') return false;
            }
            else if (c == ']')
            {
                if(stack.Count == 0 || stack.Pop() != '[') return false;
            }
            else
            {
                stack.Push(c);
            }
        }
        return stack.Count == 0;
    }
}
