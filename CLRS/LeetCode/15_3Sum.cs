namespace CLRS.LeetCode;

// problem #15: Three Sum
public partial class Solution
{
    // using TwoSum2
    public IList<IList<int>> ThreeSum1(int[] nums)
    {
        Array.Sort(nums);

        var answer = new List<IList<int>>();

        for (int i = 0; i < nums.Length && nums[i] <= 0; ++i)
        {
            if (i == 0 || nums[i] != nums[i - 1])
            {
                ThreeSum1TwoSum2(nums, -nums[i], answer, i);
            }
        }

        return answer;
    }

    public void ThreeSum1TwoSum2(int[] nums, int target, IList<IList<int>> answer, int i)
    {
        int left = i + 1;
        int right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] + nums[right] == target)
            {
                answer.Add(new int[] { nums[i], nums[left], nums[right] });
                while (left < right && nums[left] == nums[left + 1])
                {
                    ++left;
                }
            }

            if (nums[left] + nums[right] > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
    }

    // using TwoSum
    public IList<IList<int>> ThreeSum2(int[] nums)
    {
        Array.Sort(nums);

        var answer = new List<IList<int>>();

        for (int i = 0; i < nums.Length && nums[i] <= 0; ++i)
        {
            if (i == 0 || nums[i] != nums[i - 1])
            {
                ThreeSum2TwoSum1(nums, answer, i);
            }
        }

        return answer;
    }

    public void ThreeSum2TwoSum1(int[] nums, IList<IList<int>> answer, int i)
    {
        var map = new HashSet<int>();

        for (int j = i + 1; j < nums.Length; ++j)
        {
            int complement = -nums[i] - nums[j];
            if (map.Contains(complement))
            {
                answer.Add(new int[] { nums[i], nums[j], complement });
                while (j + 1 < nums.Length && nums[j] == nums[j + 1])
                {
                    ++j;
                }
            }

            map.Add(nums[j]);
        }
    }
}
