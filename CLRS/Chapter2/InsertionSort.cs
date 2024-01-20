namespace CLRS.Chapter2;

public class InsertionSort
{
    public static void Sort(int[] input)
    {
        for (int i = 1; i < input.Length; ++i)
        {
            int key = input[i];
            int j = i - 1;
            while (j >= 0 && input[j] > key)
            {
                input[j + 1] = input[j];
                --j;
            }
            
            input[j + 1] = key;
        }
    }
}
