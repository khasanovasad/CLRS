namespace CLRS.LeetCode;

// problem #5: Longest Palindromic Substring
// time complexity: O (n^2)
public partial class Solution
{
    public string LongestPalindrome(string s)
    {
        int n = s.Length;
        var dp = new bool[n, n];
        int start = 0, end = 0;

        // all single characters are palindromes
        for (int i = 0; i < n; ++i)
        {
            dp[i, i] = true;
        }

        // checking all 2 length substrings
        for (int i = 0; i < n - 1; ++i)
        {
            if (s[i] == s[i + 1])
            {
                dp[i, i + 1] = true;
                start = i;
                end = i + 1;
            }
        }

        // starting from 3 length substrings
        // checking all with the foundation dp table
        for (int diff = 2; diff < n; ++diff)
        {
            for (int i = 0; i < n - diff; ++i)
            {
                int j = i + diff;
                if (s[i] == s[j] && dp[i + 1, j - 1])
                {
                    dp[i, j] = true;
                    start = i;
                    end = j;
                }
            }
        }

        return s.Substring(start, end - start + 1);
    }
}
