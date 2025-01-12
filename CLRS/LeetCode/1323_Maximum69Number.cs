using System.Text;

namespace CLRS.LeetCode;

// problem #1323: Maximum 69 Number
public partial class Solution
{
    public int Maximum69Number(int num)
    {
        var digits = num.ToString();
        var strBuilder = new StringBuilder();

        bool changed = false;

        for (int i = 0; i < digits.Length; ++i)
        {
            if (digits[i] == '6' && !changed)
            {
                strBuilder.Append('9');
                changed = true;
            }
            else
            {
                strBuilder.Append(digits[i]);
            }
        }

        return Int32.Parse(strBuilder.ToString());
    }
}
