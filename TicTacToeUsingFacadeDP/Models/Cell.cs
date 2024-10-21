using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacadeDP.Models
{
    public class Cell
    {
        public MarkType Mark { get; set; }

        public Cell()
        {
            Mark = MarkType.Empty;
        }

        public bool IsEmpty()
        {
            return Mark == MarkType.Empty;
        }
    }


}
