namespace CLRS.LeetCode;

// problem #875: Koko Eating Bananas
public partial class Solution
{
    public int MinEatingSpeed(int[] piles, int h)
    {
        int left = 1;
        int right = piles.Max();

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (CheckBananaEatingSpeed(piles, mid, h))
            {
                right = mid - 1;
            }
            else 
            {
                left = mid + 1;
            }
        }

        return left;
    }

    public bool CheckBananaEatingSpeed(int[] piles, int k, int h)
    {
        long thisExample = 0;
        foreach (int pile in piles)
        {
            thisExample += (int)Math.Ceiling((double) pile / k);
        }

        return thisExample <= h;
    }
}
