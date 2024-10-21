using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacadeDP.Models
{
    public class ResultAnalyser
    {
        public GameState Analyse(Board board)
        {
            var cells = board.GetCells();
            
            for (int i = 0; i < 3; i++)
            {
              
                if (cells[i, 0].Mark == cells[i, 1].Mark && cells[i, 1].Mark == cells[i, 2].Mark && cells[i, 0].Mark != MarkType.Empty)
                {
                    return cells[i, 0].Mark == MarkType.X ? GameState.X_Wins : GameState.O_Wins;
                }

                
                if (cells[0, i].Mark == cells[1, i].Mark && cells[1, i].Mark == cells[2, i].Mark && cells[0, i].Mark != MarkType.Empty)
                {
                    return cells[0, i].Mark == MarkType.X ? GameState.X_Wins : GameState.O_Wins;
                }
            }

           
            if (cells[0, 0].Mark == cells[1, 1].Mark && cells[1, 1].Mark == cells[2, 2].Mark && cells[0, 0].Mark != MarkType.Empty)
            {
                return cells[0, 0].Mark == MarkType.X ? GameState.X_Wins : GameState.O_Wins;
            }

            if (cells[0, 2].Mark == cells[1, 1].Mark && cells[1, 1].Mark == cells[2, 0].Mark && cells[0, 2].Mark != MarkType.Empty)
            {
                return cells[0, 2].Mark == MarkType.X ? GameState.X_Wins : GameState.O_Wins;
            }

           
            bool isDraw = true;
            foreach (var cell in cells)
            {
                if (cell.IsEmpty())
                {
                    isDraw = false;
                    break;
                }
            }

            return isDraw ? GameState.Draw : GameState.Ongoing;
        }
    }
}
