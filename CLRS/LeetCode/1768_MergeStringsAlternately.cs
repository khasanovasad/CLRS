using System.Text;

namespace CLRS.LeetCode;

// problem: 1768: Merge Strings Alternately
public partial class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        var strBuilder = new StringBuilder();

        int i = 0;
        int j = 0;
        while (i < word1.Length || j < word2.Length)
        {
            if (i < word1.Length)
            {
                strBuilder.Append(word1[i++]);
            }

            if (j < word2.Length)
            {
                strBuilder.Append(word2[j++]);
            }
        }

        return strBuilder.ToString();
    }
}
