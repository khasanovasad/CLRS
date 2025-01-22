namespace CLRS.LeetCode;

// problem #438: Find All Anagrams In A String
public partial class Solution
{
    // god i hate myself for writing such a complex code
    // while simpler code that does the same thing exists
    public IList<int> FindAnagrams(string s, string p)
    {
        if (p.Length > s.Length)
        {
            return [];
        }

        var answer = new List<int>();

        var sMap = new int[26];
        var pMap = new int[26];

        for (int i = 0; i < p.Length; ++i)
        {
            ++pMap[p[i] - 'a'];
            ++sMap[s[i] - 'a'];
        }

        int formed = 0;
        for (int i = 0; i < 26; ++i)
        {
            if (sMap[i] == pMap[i])
            {
                ++formed;
            }
        }

        int left = 0;
        int right = p.Length - 1;
        
        if (formed == 26)
        {
            answer.Add(left);
        }
        
        while (right < s.Length - 1)
        {   
            ++right;
            ++sMap[s[right] - 'a'];
            if (sMap[s[right] - 'a'] == pMap[s[right] - 'a'])
            {
                ++formed;
            }
            else if (sMap[s[right] - 'a'] == pMap[s[right] - 'a'] + 1)
            {
                --formed;
            }

            --sMap[s[left] - 'a'];
            if (sMap[s[left] - 'a'] == pMap[s[left] - 'a'])
            {
                ++formed;
            }
            else if (sMap[s[left] - 'a'] == pMap[s[left] - 'a'] - 1)
            {
                --formed;
            }
            ++left;

            if (formed == 26)
            {
                answer.Add(left);
            }
        }

        return answer;
    }
}
