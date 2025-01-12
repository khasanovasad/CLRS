namespace CLRS.LeetCode;

// problem #74: Search a 2D Matrix
public partial class Solution
{
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int m = matrix.Length;
        int n = matrix[0].Length;

        int left = 0;
        int right = (m * n) - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (matrix[mid / n][mid % n] == target)
            {
                return true;
            }

            if (matrix[mid / n][mid % n] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return false;
    }
}
