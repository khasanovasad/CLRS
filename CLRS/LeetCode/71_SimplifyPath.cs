using System.Text;

namespace CLRS.LeetCode;

// problem #71: Simplify Path
public partial class Solution
{
    public string SimplifyPath(string path)
    {
        var elements = path.Split('/');
        var stack = new Stack<string>();

        foreach (string element in elements)
        {
            if (element.Length == 0)
            {
                continue;
            }

            if (element == "..")
            {
                _ = stack.TryPop(out _);
                continue;
            }

            if (element == ".")
            {
                continue;
            }

            stack.Push("/" + element);
        }

        var strBuilder = new StringBuilder();
        while (stack.Count > 0)
        {
            strBuilder.Insert(0, stack.Pop());
        }

        return strBuilder.Length == 0 ? "/" : strBuilder.ToString();
    }
}
