namespace CLRS.LeetCode;

// 161. One Edit Distance
public partial class Solution
{
    // "abxcd" -> "abycd"
    // "abcd" -> "abxcd"
    public bool IsOneEditDistance(string s, string t)
    {
        int ns = s.Length;
        int nt = t.Length;

        if (ns > nt)
        {
            return IsOneEditDistance(t, s);
        }

        if (nt - ns > 1)
        {
            return false;
        }

        for (int i = 0; i < ns; ++i)
        {
            if (s[i] != t[i])
            {
                if (ns == nt)
                {
                    return s.Substring(i + 1) == t.Substring(i + 1);
                }
                else
                {
                    return s.Substring(i) == t.Substring(i + 1);
                }
            }
        }

        return ns + 1 == nt;        
    }
}
