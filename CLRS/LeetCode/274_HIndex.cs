namespace CLRS.LeetCode;

// problem #274: H-Index
public partial class Solution
{
    public int HIndex(int[] citations)
    {
        Array.Sort(citations, (a, b) => b.CompareTo(a));

        int i;
        for (i = 0; i < citations.Length; ++i)
        {
            if (citations[i] <= i)
            {
                break;
            }
        }

        return i;
    }
}
