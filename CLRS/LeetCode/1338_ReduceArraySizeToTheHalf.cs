namespace CLRS.LeetCode;

// problem #1338: Reduce Array Size to The Half
public partial class Solution
{
    public int MinSetSize(int[] arr)
    {
        var map = new Dictionary<int, int>();
        foreach (int num in arr)
        {
            if (map.ContainsKey(num))
            {
                map[num]++;
            }
            else
            {
                map[num] = 1;
            }
        }

        var frequencies = map.Values.OrderByDescending(x => x).ToList();

        int answer = 0;
        int currentSize = arr.Length;

        for (int i = 0; i < frequencies.Count; ++i)
        {
            if (currentSize <= arr.Length / 2)
            {
                break;
            }

            answer++;
            currentSize -= frequencies[i];
        }

        return answer;
    }
}
