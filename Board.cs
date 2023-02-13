namespace TicTacToe;

public class Board
{
    private static readonly string[,] Start;

    public string[,] board;

    public Board()
    {
        board = Start;
    }
    
    static Board()
    {
        Start = new[,] {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };
    }

    public bool SetField(string input, string playerSymbol)
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] == input)
                {
                    board[i, j] = playerSymbol;
                    return true;
                }
            }
        }
        Console.WriteLine("Incorrect input. Please try again!");
        return false;
    }
    public virtual void ShowBoard()
    {
        Console.Clear();
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[0, 0]}  |  {board[0, 1]}  |  {board[0, 2]}  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[1, 0]}  |  {board[1, 1]}  |  {board[1, 2]}  ");
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine($"  {board[2, 0]}  |  {board[2, 1]}  |  {board[2, 2]}  ");
        Console.WriteLine("     |     |     ");
    }

    public string CheckWinner()
    {
        for (int i = 0; i < board.GetLength(0); i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 0] == board[i, 2])
                return board[i, 0];
            if (board[0, i] == board[1, i] && board[0, i] == board[2, i])
                return board[0, i];
        }

        if (board[0, 0] == board[1, 1] && board[0, 0] == board[2, 2])
            return board[0, 0];
        if (board[0, 2] == board[1, 1] && board[0, 2] == board[2, 0])
            return board[0, 2];

        return String.Empty;
    }

    public void ClearBoard()
    {
        board = new[,] {
            { "1", "2", "3" },
            { "4", "5", "6" },
            { "7", "8", "9" }
        };
    }
    
}