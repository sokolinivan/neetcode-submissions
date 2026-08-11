public class Solution {
	public bool IsValidSudoku(char[][] board)
	{
		var rowHash = Enumerable.Range(0, board.Length)
							.Select(_ => new HashSet<char>())
							.ToArray();
		var columsHash = Enumerable.Range(0, board.Length)
							.Select(_ => new HashSet<char>())
							.ToArray();
							
		var squares = Enumerable.Range(0, board.Length)
								.Select(_ => new HashSet<char>())
								.ToArray();

		for (int row = 0; row < board.Length; row++)
		{
			for (int col = 0; col < board[row].Length; col++)
			{
				if (board[row][col] == '.')
				{
					continue;
				}

				if (!rowHash[row].Add(board[row][col]))
				{
					return false;
				}

				if (!columsHash[col].Add(board[row][col]))
				{
					return false;
				}
				
				var squareIndex = (row / 3) * 3 + (col / 3);
				
				if(!squares[squareIndex].Add(board[row][col])){
					return false;
				}
			}
		}
		
		return true;
	} 
}