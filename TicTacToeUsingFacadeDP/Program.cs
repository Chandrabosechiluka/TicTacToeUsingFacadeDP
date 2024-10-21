using TicTacToeUsingFacadeDP.Models;

namespace TicTacToeUsingFacadeDP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameService gameService = new GameService();
            gameService.StartGame();
        }
    }
}
