namespace TicTacToe;

public class Game
{
    private const string _player1 = "O";
    private const string _player2 = "X";
    private int Round = 1;
    private readonly Board _board;

    public Game(Board board)
    {
        _board = board;
    }

    public void PlayRound()
    {
        var currentPlayer = Round % 2 != 0 ? _player1 : _player2;
        var valid = false;
        _board.ShowBoard();
        Console.WriteLine($"Round: {Round} Player: {currentPlayer}");
        while (!valid)
        {
            Console.WriteLine("Choose a field (1-9)");
            var playerInput = Console.ReadLine()!;
            valid = _board.SetField(playerInput, currentPlayer);
        }

        Round++;
        Console.WriteLine(Round);
    }

    public bool IsWinner()
    {
        var winner = _board.CheckWinner();
        if (!winner.Equals(""))
        {
            _board.ShowBoard();
            Console.WriteLine($"Players {winner} has won!");
            return true;
        }

        if (Round == 10)
        {
            _board.ShowBoard();
            Console.WriteLine("It is a draw!");
            return true;
        }

        return false;
    }
}