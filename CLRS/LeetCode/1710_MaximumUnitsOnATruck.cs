namespace CLRS.LeetCode;

// problem #1710: Maximum Units on a Truck
public partial class Solution
{
    public int MaximumUnits(int[][] boxTypes, int truckSize)
    {
        boxTypes = boxTypes.OrderByDescending(x => x[1]).ToArray();

        int answer = 0;
        foreach (var boxDef in boxTypes)
        {
            if (boxDef[0] <= truckSize)
            {
                truckSize -= boxDef[0];
                answer += boxDef[1] * boxDef[0];
            }
            else if (boxDef[0] > truckSize && truckSize != 0)
            {
                answer += boxDef[1] * truckSize;
                truckSize = 0;
            }
        }

        return answer;
    }
}
