namespace CLRS.LeetCode;

// problem #2743: Count Substrings Without Repeating Character
public partial class Solution
{
    public int NumberOfSpecialSubstrings(string s)
    {
        int answer = 0;
        var map = new Dictionary<char, int>();

        int left = 0;
        for (int right = 0; right < s.Length; ++right)
        {
            char c = s[right];
            if (!map.ContainsKey(c))
            {
                map.Add(c, 0);
            }
            ++map[c];

            while (map[c] > 1)
            {
                map.Remove(s[left]);
                left++;
            }

            answer += right - left + 1;
        }

        return answer;
    }
}
