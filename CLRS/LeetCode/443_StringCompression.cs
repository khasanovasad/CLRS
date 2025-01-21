namespace CLRS.LeetCode;

// problem #443: String Compression
public partial class Solution
{
    public int Compress(char[] chars)
    {
        int res = 0;

        for (int i = 0; i < chars.Length; )
        {
            char c = chars[i];
            int groupLength = 1;

            for (int j = i + 1; j < chars.Length; ++j)
            {
                if (c == chars[j])
                {
                    ++groupLength;
                }
                else
                {
                    break; 
                }
            }

            chars[res++] = c;
            if (groupLength > 1)
            {
                foreach (char digit in groupLength.ToString())
                {
                    chars[res++] = digit;
                }
            }

            i += groupLength;
        }

        return res;
    }
}
