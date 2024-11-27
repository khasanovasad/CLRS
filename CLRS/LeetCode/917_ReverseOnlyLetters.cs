namespace CLRS.LeetCode;

// problem #917: Reverse Only Letters
public partial class Solution
{
    public string ReverseOnlyLetters(string s)
    {
        int left = 0;
        int right = s.Length - 1;
        var chars = s.ToCharArray();
        while (right > left)
        {
            if ((chars[left] < 65 || chars[left] > 90) && (chars[left] < 97 || chars[left] > 122))
            {
                left++;
                continue;
            }
            else if ((chars[right] < 65 || chars[right] > 90) && (chars[right] < 97 || chars[right] > 122))
            {
                right--;
                continue;
            }
            else
            {
                var temp = chars[left];
                chars[left] = chars[right];
                chars[right] = temp;
                left++;
                right--;
            }
        }

        return new string(chars);
    }
}