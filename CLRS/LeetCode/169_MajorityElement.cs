namespace CLRS.LeetCode;

// problem #169: Majority Element
public partial class Solution
{
    // just think about an example: [1,2,1]
    // first two elements would cancel each other
    // leaving us with count = 0, the next element would
    // be the candidate since the count = 0 and the answer
    // would be correct
    // this is called Boyer-Moore Voting Algorithm
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int? candidate = null;

        foreach (int num in nums)
        {
            if (count == 0)
            {
                candidate = num;
            }

            count += (num == candidate) ? 1 : -1;
        }

        return candidate!.Value;
    }
}
