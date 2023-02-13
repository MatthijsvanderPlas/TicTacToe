namespace TicTacToe;

internal abstract class Program
{
    public static void Main()
    {
        // Main will be a while loop "playing" the game until someone wins or there is a draw
        // Class of Board will have all the logic for creating, updating and checking for a winner
        
        bool playGame = true;
        
        while (playGame)
        {
            // big loop creates a new fresh board. 
            // starts the inner game loop
            // handles the restart of the game
            Board board = new Board();     
            Game newGame = new Game(board);   
            bool winner = false;
            
            
            // Inner loop handles the single games logic 
            // going through each round adding X or O
            // checking for a winner or if there is now winner at round 9 its a draw
            while (!winner)
            {
                newGame.PlayRound();
                winner = newGame.IsWinner();
            }
            // If you wish to play again playGame will be true and starts a new loop
            // any other input will end the game
            Console.WriteLine("Play again y/n?");
            playGame = Restart(Console.ReadLine()!);
            if (playGame)
            {
                // start a new board for the next round.
                board.ClearBoard();
            }
        }
    }

    private static bool Restart(string playerChoice) => playerChoice == "y";
}

