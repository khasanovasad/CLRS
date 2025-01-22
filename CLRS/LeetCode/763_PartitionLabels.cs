namespace CLRS.LeetCode;

// problem #763: Partition Labels
public partial class Solution
{
    public IList<int> PartitionLabels(string s)
    {
        // "ababcbacadefegdehijhklij"        
        // a: 8, b: 5, c: 7, d: 14, e: 16, h: 20, i: 23, k: 21, j: 24
        var last = new int[26];
        
        for (int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            last[c - 'a'] = i;
        }

        var answer = new List<int>();

        int start = 0, end = 0;
        for (int i = 0; i < s.Length; ++i)
        {
            char c = s[i];
            end = Math.Max(end, last[c - 'a']);

            if (end == i)
            {
                answer.Add(end - start + 1);
                start = i + 1;
            }
        } 

        return answer;
    }
}
