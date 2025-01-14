using System.Text;

namespace CLRS.LeetCode;

// problem #22: Generate Parentheses

// explanation: the string will only be invalid if
// at any index of the string, the number of closing parenthesis
// exceeds the number of opening parenthesis
// so, in this algorithm, we are only adding closing parenthesis
// if the number of it's count is less than opening parenthesis count

/*
example: for n = 3

Valid Strings:
((()))
(()())
(())()
()(())
()()()

Invalid Strings:
())((
)((())
(()))(

as you can see above, the number of closing parenthesis exceeds the number
of opening parenthesis at some index in all invalid strings
*/

public partial class Solution
{
    public IList<string> GenerateParenthesis(int n)
    {
        var answer = new List<string>();
        var current = new StringBuilder();
        GenerateParenthesisBacktrack(answer, current, n, 0, 0);
        return answer;
    }

    public void GenerateParenthesisBacktrack(IList<string> answer, StringBuilder current, int n, int opens, int closes)
    {
        if (current.Length == n * 2)
        {
            answer.Add(current.ToString());
            return;
        }

        if (opens < n)
        {
            current.Append('(');
            GenerateParenthesisBacktrack(answer, current, n, opens + 1, closes);
            current.Remove(current.Length - 1, 1);
        }
        
        if (opens > closes)
        {
            current.Append(')');
            GenerateParenthesisBacktrack(answer, current, n, opens, closes + 1);
            current.Remove(current.Length - 1, 1);
        }
    }
}
