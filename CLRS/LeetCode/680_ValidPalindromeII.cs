namespace CLRS.LeetCode;

// problem #680: Valid Palindrome II
public partial class Solution
{
    // "cbbcc"
    public bool ValidPalindrome(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        while (left < right)
        {
            if (s[left] != s[right])
            {
                return ValidPalindromeInternal(s, left + 1, right) || ValidPalindromeInternal(s, left, right - 1);
            }
            ++left;
            --right;
        }

        return true;
    }

    private bool ValidPalindromeInternal(string s, int i, int j)
    {
        while (i < j)
        {
            if (s[i] != s[j])
            {
                return false;
            }
            ++i;
            --j;
        }

        return true;
    }
}
