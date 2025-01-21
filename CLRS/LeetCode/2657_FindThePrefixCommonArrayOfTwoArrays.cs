namespace CLRS.LeetCode;

public partial class Solution
{
    // array.Length = A.Length
    // for
    // array[A[i]]++;
    // array[B[i]]++;
    // if (array[A[i]] == 2)
    //  result[i] += result[i - 1] + 1;

    // A = [2,3,1]
    // B = [3,1,2]
    // [2, 2, 2]
    // [0, 1, 3]

    // A = [1,3,2,4]
    // B = [3,1,2,4]
    // counter = [2,2,2,0]
    // answer =  [0,2,3,4]
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        int n = A.Length;
        var answer = new int[n];
        var frequencyCounter = new int[n];
        for (int i = 0; i < n; ++i)
        {
            if (i >= 1)
            {
                answer[i] = answer[i - 1];
            }

            frequencyCounter[A[i] - 1]++;
            frequencyCounter[B[i] - 1]++;

            if (frequencyCounter[A[i] - 1] == 2)
            {
                ++answer[i];
            }

            if (frequencyCounter[B[i] - 1] == 2 && B[i] != A[i])
            {
                ++answer[i];
            }
        }
        return answer;
    }
}
