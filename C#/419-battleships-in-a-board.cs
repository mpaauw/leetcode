public static int CountBattleships(char[,] board)
{
    int count = 0;
    for(int row = 0; row < board.GetLength(0); row++)
    {
        for(int col = 0; col < board.GetLength(1); col++)
        {
            if(board[row, col].Equals('X') && (row == 0 || board[row - 1, col].Equals('.')) && (col == 0 || board[row, col - 1].Equals('.')))
            {
                count += 1;
            } 
        }
    }
    return count;
}