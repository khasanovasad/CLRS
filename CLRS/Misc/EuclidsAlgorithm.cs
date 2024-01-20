namespace CLRS.Misc;

public static class EuclidsAlgorithm
{
    public static int GCD(int a, int b)
    {
        while (true)
        {
            if (b == 0)
            {
                return a;
            }

            var aTemp = a;
            a = b;
            b = aTemp % b;
        }
    }
}