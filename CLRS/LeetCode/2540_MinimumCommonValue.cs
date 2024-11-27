namespace CLRS.LeetCode;

// problem #2540: Minimum Common Values
public partial class Solution
{
    public int GetCommon(int[] nums1, int[] nums2)
    {
        var nums1Doubled = new Dictionary<int, bool>();
        for (int i = 0; i < nums1.Length; ++i)
        {
            if (!nums1Doubled.ContainsKey(nums1[i]))
            {
                nums1Doubled.Add(nums1[i], true);
            }
        }

        int? minCommon = null;
        for (int i = 0; i < nums2.Length; ++i)
        {
            if (nums1Doubled.ContainsKey(nums2[i]))
            {
                minCommon = Math.Min(nums2[i], minCommon ?? Int32.MaxValue);
            }
        }

        return minCommon ?? -1;
    }

    public int GetCommon2(int[] nums1, int[] nums2)
    {
        int ptr1 = 0, ptr2 = 0;
        int commonMinValue = Int32.MaxValue;
        while (ptr1 < nums1.Length && ptr2 < nums2.Length)
        {
            if (nums1[ptr1] > nums2[ptr2])
            {
                ptr2++;
            }
            else if (nums1[ptr1] < nums2[ptr2])
            {
                ptr1++;
            }
            else
            {
                commonMinValue = Math.Min(commonMinValue, nums1[ptr1]);
                ptr1++;
                ptr2++;
            }
        }

        return commonMinValue == Int32.MaxValue ? -1 : commonMinValue;
    }
}