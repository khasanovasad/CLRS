namespace CLRS.LeetCode;

// problem #567: Permutation in String
public partial class Solution
{
    #region HashMap Solution
    // O (l1 + (l2 - l1) * (l1 + 26))
    public bool CheckInclusionHashMap(string s1, string s2)
    {
        var s1Map = new Dictionary<char, int>();
        foreach (char c in s1)
        {
            if (!s1Map.ContainsKey(c))
            {
                s1Map[c] = 0;
            }
            ++s1Map[c];
        }

        for (int i = 0; i <= s2.Length - s1.Length; ++i)
        {
            var s2Map = new Dictionary<char, int>();
            for (int j = 0; j < s1.Length; ++j)
            {
                char c = s2[i + j];
                if (!s2Map.ContainsKey(c))
                {
                    s2Map[c] = 0;
                }
                ++s2Map[c];
            }

            if (CheckInclusionHashmapMatch(s1Map, s2Map))
            {
                return true;
            }
        }

        return false;
    }

    public bool CheckInclusionHashmapMatch(Dictionary<char, int> s1Map, Dictionary<char, int> s2Map)
    {
        foreach (var (key, _) in s1Map)
        {
            if (!s2Map.ContainsKey(key) || s1Map[key] != s2Map[key])
            {
                return false;
            }
        }

        return true;
    }
    #endregion

    // O (l1 + (l2 - l1) * 26) = O (26 * l2 - 25 * l1) = O (l2)
    public bool CheckInclusionArr(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        var s1Map = new int[26];
        var s2Map = new int[26];
        for (int i = 0; i < s1.Length; ++i)
        {
            s1Map[s1[i] - 'a']++;
            s2Map[s2[i] - 'a']++;
        }

        for (int i = 0; i < s2.Length - s1.Length; ++i)
        {
            if (CheckInclusionArrMatch(s1Map, s2Map))
            {
                return true;
            }

            s2Map[s2[i] - 'a']--;
            s2Map[s2[i + s1.Length] - 'a']++;
        }

        return CheckInclusionArrMatch(s1Map, s2Map);
    }

    public bool CheckInclusionArrMatch(int[] s1Map, int[] s2Map)
    {
        for (int i = 0; i < 26; ++i)
        {
            if (s1Map[i] != s2Map[i])
            {
                return false;
            }
        }

        return true;
    }

    // O (l1 + 26 + l2 - l1) = O (l2 + 26) = O (l2)
    public bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length)
        {
            return false;
        }

        var s1Map = new int[26];
        var s2Map = new int[26];
        for (int i = 0; i < s1.Length; ++i)
        {
            s1Map[s1[i] - 'a']++;
            s2Map[s2[i] - 'a']++;
        }

        int count = 0;
        for (int i = 0; i < 26; ++i)
        {
            if (s1Map[i] == s2Map[i])
            {
                ++count;
            }
        }

        for (int i = 0; i < s2.Length - s1.Length; ++i)
        {
            int r = s2[i + s1.Length] - 'a';
            int l = s2[i] - 'a';

            if (count == 26)
            {
                return true;
            }

            ++s2Map[r];
            if (s1Map[r] == s2Map[r])
            {
                ++count;
            }
            else if (s1Map[r] + 1 == s2Map[r])
            {
                --count;
            }

            --s2Map[l];
            if (s1Map[l] == s2Map[l])
            {
                ++count;
            }
            else if (s1Map[l] - 1 == s2Map[l])
            {
                --count;
            }
        }

        return count == 26;
    }
}