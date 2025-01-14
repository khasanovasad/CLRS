namespace CLRS.LeetCode;

// problem #7: Reverse Integer
public partial class Solution
{
    public int Reverse(int x)
    {
        int reversed = 0;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;

            // 1. if reversed is already bigger than (Int32.MaxValue - the last digit)
            // OR
            // 2. if reversed is equal to (Int32.MaxValue - the last digit) AND pop is bigger than 7
            // because the last digit of Int32.MaxValue is 7
            if ((reversed > Int32.MaxValue / 10) || (reversed == Int32.MaxValue / 10 && pop > 7))
            {
                return 0;
            }
            else if ((reversed < Int32.MinValue / 10) || (reversed == Int32.MaxValue / 10 && pop < -8))
            {
                return 0;
            }

            reversed = reversed * 10 + pop;
        }

        return reversed;
    }
}
