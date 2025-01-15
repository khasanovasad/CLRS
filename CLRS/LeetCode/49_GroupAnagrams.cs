namespace CLRS.LeetCode;

// problem #49: Group Anagrams
public partial class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        var map = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; ++i)
        {
            string str = new string(strs[i].Order().ToArray());

            if (map.ContainsKey(str))
            {
                map[str].Add(str);
            }
            else
            {
                map.Add(str, new List<string>() { str });
            }
        }

        return map.Values.ToArray();
    }
}
