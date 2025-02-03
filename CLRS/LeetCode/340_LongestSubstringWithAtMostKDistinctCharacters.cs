namespace CLRS.LeetCode;

// 340. Longest Substring with At Most K Distinct Characters
public partial class Solution
{
    // "eceba", k = 2, 3, "ece"
    public int LengthOfLongestSubstringKDistinct(string s, int k)
    {
        var set = new Dictionary<char, int>(); 
        int answer = 0;
        int left = 0;
        int right = 0;
        int currentDistinct = 0;

        while (right < s.Length)
        {
            char c = s[right];
            if (!set.ContainsKey(c))
            {
                set.Add(c, 0);
                ++currentDistinct;
            }
            ++set[c];

            while (currentDistinct > k)
            {
                if (set[s[left]] == 1)
                {
                    --currentDistinct;
                }
                --left;
            }

            answer = Math.Max(answer, right - left);
            ++right;
        }

        return answer;
    }
}
