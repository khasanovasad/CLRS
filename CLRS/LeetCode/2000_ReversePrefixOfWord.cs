using System.Text;

namespace CLRS.LeetCode;

// problem #2000: Reverse Prefix Of Word
public partial class Solution
{
    public string ReversePrefix(string word, char ch)
    {
        if (word.Length == 0)
        {
            return word;
        }

        int right = 0;
        for (int i = 0; i < word.Length; ++i)
        {
            if (word[i] == ch)
            {
                right = i;
                break;
            }
        }

        var strBuilder = new StringBuilder();
        for (int i = right; i >= 0; --i)
        {
            strBuilder.Append(word[i]);
        }

        for (int i = right + 1; i < word.Length; ++i)
        {
            strBuilder.Append(word[i]);
        }

        return strBuilder.ToString();
    }
}