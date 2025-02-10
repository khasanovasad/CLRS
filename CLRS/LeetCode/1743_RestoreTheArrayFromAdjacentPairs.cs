namespace CLRS.LeetCode;

public partial class Solution
{
    public int[] RestoreArray(int[][] adjacentPairs)
    {
        var map = new Dictionary<int, List<int>>();     
        foreach (var cells in adjacentPairs)
        {
            if (!map.ContainsKey(cells[0]))
            {
                map.Add(cells[0], new List<int>());
            }
            map[cells[0]].Add(cells[1]);

            if (!map.ContainsKey(cells[1]))
            {
                map.Add(cells[1], new List<int>());
            }
            map[cells[1]].Add(cells[0]);
        }

        int current = 0;
        int previous = 0;
        foreach (var (key, values) in map)
        {
            if (values.Count == 1)
            {
                previous = key;
                current = values[0];
                break;
            }
        }

        var answer = new List<int>();
        answer.Add(previous);
        answer.Add(current);
        map.Remove(previous);

        // 2: 1, 3
        // 3: 2, 4
        // 1: 2
        // 4: 3
        while (map.Count > 1)
        {
            int index = map[current][0] != previous ? 0 : 1;

            int toBeDeleted = current;
            previous = current;
            current = map[current][index];
            answer.Add(current);
            map.Remove(toBeDeleted);
        }

        return answer.ToArray();
    }
}
