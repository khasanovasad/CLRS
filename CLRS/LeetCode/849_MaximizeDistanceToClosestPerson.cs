namespace CLRS.LeetCode;

// problem #849: Maximize Distance to Closest Personk
public partial class Solution
{
    // [1,0,0,0,1,0,1]

    // [1, 0, 0, 0]

    // [0, 0, 1, 0]

    // [0, 0, 0, 1]

    // [1,0,0,1,0,0,0,1,1,1,0,0,0,0,0,0,1,0,0,0,0,0]
    public int MaxDistToClosest(int[] seats)
    {
        int previous = -1;
        int answer = Int32.MinValue;

        for (int i = 0; i < seats.Length; ++i)
        {
            if (seats[i] == 1)
            {
                if (previous == -1)
                {
                    answer = i;
                }
                else
                {
                    answer = Math.Max(answer, (i - previous) / 2);
                }
                previous = i;
            }
        }

        if (seats[seats.Length - 1] == 0)
        {
            answer = Math.Max(answer, seats.Length - 1 - previous);
        }

        return answer;
    }

    // doesn't work for leading 0s ([0, 0, 1])
    public int MaxDistToClosestMySolution(int[] seats)
    {
        int left = 0;
        int right = 0;

        int longestStartIndex = 0;

        int longestLength = 0;
        int current = 0;

        while (right < seats.Length)
        {
            if (seats[right] == 0)
            {
                ++current;
                if (current >= longestLength)
                {
                    longestLength = current;
                    longestStartIndex = right - longestLength + 1;
                }
            }
            else
            {
                current = 0;
                left = right;
            }

            ++right;
        }

        int answer = 0;
        if (longestStartIndex > 0 && seats[longestStartIndex - 1] == 1 && longestStartIndex + longestLength < seats.Length && seats[longestStartIndex + longestLength] == 1)
        {
            answer = (longestLength + 1) / 2;
        }
        else
        {
            answer = longestLength;
        }

        if (seats[seats.Length - 1] == 0)
        {
            answer = Math.Max(answer, seats.Length - 1 - left);
        }

        return answer;
    }
}