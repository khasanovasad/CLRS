namespace CLRS.LeetCode;

// problem #763: Partition Labels
public partial class Solution
{
    public IList<int> PartitionLabels(string s)
    {
        // "ababcbacadefegdehijhklij"
        var lastOccurance = new int[26];
        var answer = new List<int>();

        for (int i = 0; i < s.Length; ++i)
        {
            int index = s[i] - 'a';
            lastOccurance[index] = i;
        }

        int left = 0;
        for (int i = 0; i < s.Length; )
        {
            int index = s[i] - 'a';
            int candidate = lastOccurance[index];
            while (i <= candidate)
            {
                if (candidate < lastOccurance[s[i] - 'a'])
                {
                    candidate = lastOccurance[s[i] - 'a'];
                }
                ++i;
            }
            answer.Add(candidate - left + 1);
            left = candidate + 1;
        }

        return answer;
    }
}
