using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacadeDP.Models
{
    public class Game
    {
        private Board _board;
        private Player _currentPlayer;
        private Player _player1;
        private Player _player2;
        private ResultAnalyser _resultAnalyser;
        private GameState _currentState;

        public Game(Player player1, Player player2)
        {
            _player1 = player1;
            _player2 = player2;
            _currentPlayer = _player1;
            _board = new Board();
            _resultAnalyser = new ResultAnalyser();
            _currentState = GameState.Ongoing;
        }

        public GameState PlayTurn(int row, int col)
        {
            _board.ValidateMove(row, col);
            _board.MakeMove(row, col, _currentPlayer.Mark);
            _currentState = _resultAnalyser.Analyse(_board);

            _currentPlayer = (_currentPlayer == _player1) ? _player2 : _player1;

            return _currentState;
        }

        public void DisplayBoard()
        {
            _board.DisplayBoard();
        }

        public Player GetCurrentPlayer()
        {
            return _currentPlayer;
        }
    }
}
