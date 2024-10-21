namespace TicTacToeUsingFacadeDP.Models
{
    public class GameService
    {
        public void StartGame()
        {
            Player player1 = new Player("Player 1", MarkType.X);
            Player player2 = new Player("Player 2", MarkType.O);
            Game game = new Game(player1, player2);
            Play(game);
        }

        private void Play(Game game)
        {
            GameState state = GameState.Ongoing;

            while (state == GameState.Ongoing)
            {
                game.DisplayBoard();
                try
                {
                    int[] move = GetPlayerMove(game.GetCurrentPlayer());
                    state = game.PlayTurn(move[0], move[1]);
                }
                catch (InvalidMoveException ex)
                {
                    Console.WriteLine($"Invalid Move: {ex.Message}");
                }
            }

            AnnounceResult(state);
        }

        private int[] GetPlayerMove(Player player)
        {
            int row, col;
            while (true)
            {
                try
                {
                    Console.WriteLine($"{player.Name}'s turn. Enter row and column (0-2): ");
                    row = Convert.ToInt32(Console.ReadLine());
                    col = Convert.ToInt32(Console.ReadLine());

                    return new int[] { row, col };
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter numbers between 0 and 2.");
                }
            }
        }

        private void AnnounceResult(GameState state)
        {
            Console.WriteLine("Game Over! Result:");
            switch (state)
            {
                case GameState.X_Wins:
                    Console.WriteLine("Player 1 (X) wins!");
                    break;
                case GameState.O_Wins:
                    Console.WriteLine("Player 2 (O) wins!");
                    break;
                case GameState.Draw:
                    Console.WriteLine("It's a draw!");
                    break;
            }
        }
    }

}
