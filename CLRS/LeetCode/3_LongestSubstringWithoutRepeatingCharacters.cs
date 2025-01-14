namespace CLRS.LeetCode;

// problem #3: Longest Substring Without Repeating Characters
public partial class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var map = new Dictionary<char, bool>();

        int left = 0;
        int right = 0;
        int answer = 0;

        while (right < s.Length)
        {
            while (map.ContainsKey(s[right]))
            {
                map.Remove(s[left]);
                left++;
            }

            map[s[right]] = true;
            answer = Math.Max(answer, map.Count);
            right++;
        }

        return answer;
    }
}
