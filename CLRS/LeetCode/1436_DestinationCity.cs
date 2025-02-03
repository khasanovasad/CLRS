namespace CLRS.LeetCode;

// 1436. Destination City
public partial class Solution
{
    public string DestCity(IList<IList<string>> paths)
    {
        var map = new Dictionary<string, string>();
        string destination = null;

        foreach (var path in paths)
        {
            if (path[0] == destination || destination is null)
            {
                destination = path[1];
            }
            else
            {
                if (!map.ContainsKey(path[0]))
                {
                    map.Add(path[0], path[1]);
                }
            }
        }

        while (map.ContainsKey(destination))
        {
            destination = map[destination];
        }        

        return destination;
    }
}
