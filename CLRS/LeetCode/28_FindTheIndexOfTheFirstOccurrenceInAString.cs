namespace CLRS.LeetCode;

// problem #28: Find the Index of the First Occurrence in a String
// this is a O (n * m) solution
// there is another algorithm Knuth–Morris–Pratt Algorithm that solves
// this problem in O (n) time
public partial class Solution
{
    public int StrStr(string haystack, string needle)
    {
        if (haystack.Length < needle.Length)
        {
            return -1;
        }

        int answer = -1;
        for (int i = 0; i < haystack.Length; ++i)
        {
            if (haystack[i] == needle[0])
            {
                answer = i;
                int index = needle.Length - 1;
                while (index < haystack.Length && index > 0)
                {
                    if (haystack[i + index] != needle[index])
                    {
                        i += index;
                        answer = -1;
                        break;
                    }
                    index--;
                }

                if (answer != -1 && index + i < haystack.Length)
                {
                    return answer;
                }
            }
        }

        return -1;
    }    
}
