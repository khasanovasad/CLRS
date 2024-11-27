using System.Text;

namespace CLRS.LeetCode;

// problem #557: Reverse Words in a String III
public partial class Solution
{
    public string ReverseWords(string s)
    {
        var words = s.Split(' ');
        var strBuilder = new StringBuilder();

        for (int i = 0; i < words.Length; ++i)
        {
            var word = words[i];

            strBuilder.Append(" ");
            for (int j = word.Length - 1; j >= 0; --j)
            {
                strBuilder.Append(word[j]);
            }
        }

        return strBuilder.ToString().TrimStart();
    }
}