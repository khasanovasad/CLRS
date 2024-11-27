namespace CLRS.Chapter2;

public class SelectionSort
{
    public static void Sort(int[] input)
    {
        for (int i = 0; i < input.Length; ++i)
        {
            int smallestIdx = i;
            for (int j = smallestIdx + 1; j < input.Length; ++j)
            {
                if (input[smallestIdx] > input[j])
                {
                    smallestIdx = j;
                }
            }

            (input[i], input[smallestIdx]) = (input[smallestIdx], input[i]);
        }
    }
}
