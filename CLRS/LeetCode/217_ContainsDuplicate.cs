namespace CLRS.LeetCode;

public partial class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        var returnValue = false;
        var dict = new Dictionary<int, bool>();

        foreach (int num in nums)
        {
            if (!dict.ContainsKey(num))
            {
                dict[num] = true;
            }
            else
            {
                return true;
            }
        }

        return returnValue;
    }
}
