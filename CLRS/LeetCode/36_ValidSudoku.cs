namespace CLRS.LeetCode;

// problem #36: Valid Sudoku

// time complexity O (n ^ 2) and space complexity O (n ^ 2)
// the only improvement can be done to the space complexity O (n)
// using the bitmasking technique. But, I won't implement it here
public partial class Solution
{
    public bool IsValidSudoku(char[][] board)
    {
        var rowSet = new HashSet<char>[9];
        var columnSet = new HashSet<char>[9];
        var boxSet = new HashSet<char>[9];

        for (int i = 0; i < 9; ++i)
        {
            rowSet[i] = new HashSet<char>();
            columnSet[i] = new HashSet<char>();
            boxSet[i] = new HashSet<char>();
        }
        
        for (int row = 0; row < 9; ++row)
        {
            for (int column = 0; column < 9; ++column)
            {
                var val = board[row][column];

                if (val == '.')
                {
                    continue;
                }

                if (rowSet[row].Contains(val))
                {
                    return false;
                }
                rowSet[row].Add(val);


                if (columnSet[column].Contains(val))
                {
                    return false;
                }
                columnSet[column].Add(val);

                // check box
                // dividing the row by 3 gives us the horizontal row group (groups 0, 1, 3)
                // multiplying it by 3 gives us the starting index of the row group (indices 0, 3, 6)
                // dividing column / 3 gives us the vertical column group
                // adding these together gives us the box index
                int index = (row / 3) * 3 + column / 3;

                if (boxSet[index].Contains(val))
                {
                    return false;
                }
                boxSet[index].Add(val);
            }
        }

        return true;
    }
}
