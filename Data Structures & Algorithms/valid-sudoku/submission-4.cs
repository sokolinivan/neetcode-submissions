public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var rows = new HashSet<char>[9];
        var cols = new HashSet<char>[9];
        var boxes = new HashSet<char>[9];

        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                char val = board[row][col];

                if (val == '.')
                    continue;

                int box = (row / 3) * 3 + col / 3;

                if (!rows[row].Add(val))
                    return false;

                if (!cols[col].Add(val))
                    return false;

                if (!boxes[box].Add(val))
                    return false;
            }
        }

        return true;
    }
}
