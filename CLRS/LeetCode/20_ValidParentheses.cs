namespace CLRS.LeetCode;

// problem #20: Valid Parentheses
public partial class Solution
{
    public bool IsValid(string s)
    {
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            if (c == '(' || c == '{' || c == '[')
            {
                stack.Push(c);
            }
            else
            {
                if (stack.Count > 0
                    && ((c == ')' && stack.Peek() == '(')
                        || (c == '}' && stack.Peek() == '{')
                        || (c == ']' && stack.Peek() == '[')))
                {
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}
