namespace CLRS.Chapter2;

public class MergeSort
{
    public static void Sort(int[] input, int low, int high)
    {
        if (low == high)
        {
            return;
        }

        int mid = low + (high - low) / 2;
        Sort(input, low, mid);
        Sort(input, mid + 1, high);
        Merge(input, low, mid, high);
    }

    private static void Merge(int[] input, int low, int mid, int high)
    {
        int lLength = mid - low + 1;
        int rLength = high - mid;

        int[] left = new int[lLength];
        int[] right = new int[rLength];

        for (int i = 0; i < lLength; ++i)
        {
            left[i] = input[low + i];
        }
        for (int i = 0; i < rLength; ++i)
        {
            right[i] = input[mid + i + 1];
        }

        int l = 0;
        int r = 0;
        int k = low;
        while (l < lLength && r < rLength)
        {
            if (left[l] <= right[r])
            {
                input[k] = left[l];
                ++l;
            }
            else
            {
                input[k] = right[r];
                ++r;
            }

            ++k;
        }

        while (l < lLength)
        {
            input[k] = left[l];
            ++l;
            ++k;
        }
        
        while (r < rLength)
        {
            input[k] = right[r];
            ++r;
            ++k;
        }
    }
}