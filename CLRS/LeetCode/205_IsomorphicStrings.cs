namespace CLRS.LeetCode;

// problem #205: Isomorphic Strings
public partial class Solution
{
    // b a d c
    // b a b a
    // false

    // p a p e r
    // t i t l e

    // e g g
    // a d d
    // O (n ^ 2) because ContainsValue() runs in O (n)
    public bool IsIsomorphic1(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var map = new Dictionary<char, char>();
        for (int i = 0; i < s.Length; ++i)
        {
            char c1 = s[i];
            char c2 = t[i];

            if (!map.ContainsKey(c1) && !map.ContainsValue(c2))
            {
                map.Add(c1, c2);
            }
            else if (
                (map.ContainsKey(c1) && map[c1] != c2) ||
                (!map.ContainsKey(c1) && map.ContainsValue(c2))
            )
            {
                return false;
            }
        }

        return true;
    }

    // O (n)
    public bool IsIsomorphic2(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        var mapSToT = new int[256];
        var mapTToS = new int[256];
        for (int i = 0; i < s.Length; ++i)
        {
            char sc = s[i];
            char tc = t[i];

            if (mapSToT[sc] == 0 && mapTToS[tc] == 0)
            {
                mapSToT[sc] = tc;
                mapTToS[tc] = sc;
            }

            if (mapSToT[sc] != tc && mapTToS[tc] != sc)
            {
                return false;
            }
        }

        return true;
    }
}