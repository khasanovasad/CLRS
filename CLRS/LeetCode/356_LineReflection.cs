namespace CLRS.LeetCode;

// probolem #356: Line Reflection
public partial class Solution
{
    public bool IsReflected(int[][] points)
    {
        if (points == null || points.Length == 0)
        {
            return true;
        }

        // Step 1: Find minX and maxX
        int minX = int.MaxValue, maxX = int.MinValue;
        var pointSet = new HashSet<(int, int)>();

        foreach (var point in points)
        {
            int x = point[0], y = point[1];
            minX = Math.Min(minX, x);
            maxX = Math.Max(maxX, x);
            pointSet.Add((x, y)); // Store points as tuples
        }

        // Step 2: Compute the reflection line

        // note:
        // it is the average of the max and min x
        // it is actually calculated as (minX + maxX) / 2
        // but, according to the formule, we should also
        // multiply this value by 2 on line 40
        // thus, here we are just not dividing by 2 to
        // avoid decimal numbers and losing precision
        int reflectionLine = minX + maxX;

        // Step 3: Check if all points have their reflection
        foreach (var point in points)
        {
            int x = point[0], y = point[1];
            int reflectedX = reflectionLine - x;
            if (!pointSet.Contains((reflectedX, y)))
            {
                return false;
            }
        }

        return true;
    }
}
