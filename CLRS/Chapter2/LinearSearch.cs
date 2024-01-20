namespace CLRS.Chapter2;

public class LinearSearch
{
    public static int? Search(int[] input, int x)
    {
        int? result = null;
        foreach (var item in input)
        {
            if (item == x)
            {
                result = item;
            }
        }

        return result;
    }
}