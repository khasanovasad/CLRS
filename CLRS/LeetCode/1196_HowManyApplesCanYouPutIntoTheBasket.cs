namespace CLRS.LeetCode;

// problem #1196: How Many Apples Can You Put into the Basket
public partial class Solution
{
    public int MaxNumberOfApples(int[] weights)
    {
        const int maxWeight = 5000;

        int answer = 0;
        int currentWeight = 0;
        Array.Sort(weights);

        foreach (int weight in weights)
        {
            if (currentWeight + weight <= maxWeight)
            {
                currentWeight += weight;
                answer++;
            }
        }

        return answer;
    }
}
