namespace CLRS.LeetCode;

// 395. Longest Substring with At Least K Repeating Characters
public partial class Solution
{
    // "aaabb" k = 3
    // "ababbc" k = 2
    public int LongestSubstring(string s, int k)
    {
        int answer = 0;

        for (int maxUnique = 1; maxUnique <= 26; maxUnique++)
        {
            var freq = new int[26];
            int left = 0, right = 0;
            int unique = 0, countAtLeastK = 0;

            while (right < s.Length)
            {
                if (unique <= maxUnique)
                {
                    int index = s[right] - 'a';
                    if (freq[index] == 0) 
                    {
                        unique++;
                    }
                    freq[index]++;
                    if (freq[index] == k)
                    {
                        countAtLeastK++;
                    }
                    right++;
                }
                else
                {
                    int index = s[left] - 'a';
                    if (freq[index] == k)
                    {
                        countAtLeastK--;
                    }
                    freq[index]--;
                    if (freq[index] == 0)
                    {
                        unique--;
                    }
                    left++;
                }

                if (unique == maxUnique && unique == countAtLeastK)
                {
                    answer = Math.Max(answer, right - left);
                }
            }
        }

        return answer;
    }
}
