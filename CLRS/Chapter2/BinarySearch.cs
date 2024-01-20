namespace CLRS.Chapter2;

public class BinarySearch
{
    public static int? Search(int[] input, int x, int low, int high)
    {
        if (high - low == 0 && input[low] != x)
        {
            return null;
        }
        
        int mid = low + (high - low) / 2;
        if (input[mid] == x)
        {
            return mid;
        }

        return input[mid] > x
            ? Search(input, x, low, mid - 1)
            : Search(input, x, mid + 1, high);
    }
}