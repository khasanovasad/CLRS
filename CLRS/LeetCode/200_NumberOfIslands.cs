namespace CLRS.LeetCode;

// 200. Number of Islands
public partial class Solution
{
    public int NumIslands(char[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int answer = 0;

        for (int i = 0; i < m; ++i)
        {
            for (int j = 0; j < n; ++j)
            {
                if (grid[i][j] == '1')
                {
                    ++answer;
                    NumIslandsDfs(grid, i, j, n, m);
                }
            }
        }

        return answer;
    }

    public void NumIslandsDfs(char[][] grid, int i, int j, int n, int m)
    {
        if (i < 0 || i >= m || j < 0 || j >= n || grid[i][j] != '1')
        {
            return;
        } 

        grid[i][j] = '0';
        NumIslandsDfs(grid, i, j + 1, n, m);
        NumIslandsDfs(grid, i, j - 1, n, m);
        NumIslandsDfs(grid, i + 1, j, n, m);
        NumIslandsDfs(grid, i - 1, j, n, m);
    }
}
