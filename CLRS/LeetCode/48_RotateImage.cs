namespace CLRS.LeetCode;

// problem #48: RotateImage

// explanation: from linear algebra, if we have n x n matrix
// and we first transposed it and then reflected it, we would
// rotate the matrix by n times
// time complexity is O (2 * n ^ 2) or O ( n ^ 2 ) or O (M) where
// M is the total number of elements in the matrix
public partial class Solution
{
    public void Rotate(int[][] matrix)
    {
        Transpose(matrix);
        Reflect(matrix);
    }

    public void Transpose(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; ++i)
        {
            for (int j = i; j < matrix.Length; ++j)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
    }

    public void Reflect(int[][] matrix)
    {
        for (int i = 0; i < matrix.Length; ++i)
        {
            int left = 0;
            int right = matrix.Length - 1;
            while (left < right)
            {
                int temp = matrix[i][left];
                matrix[i][left] = matrix[i][right];
                matrix[i][right] = temp;
                ++left;
                --right;
            }
        }
    }
}
