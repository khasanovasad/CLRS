using System.Text;

namespace CLRS.LeetCode;

// problem #125: Valid Palindrome
public partial class Solution
{
    public bool IsPalindrome(string s)
    {
        var strBuilder = new StringBuilder();
        foreach (char c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                strBuilder.Append(c);
            }
        }

        var sNew = strBuilder.ToString().ToLower();

        int left = 0;
        int right = sNew.Length - 1;
        while (left < right)
        {
            if (sNew[left] != sNew[right])
            {
                return false;
            }
            ++left;
            --right;
        }

        return true;
    }
}
