using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeUsingFacadeDP.Models
{
    public class Player
    {
        public string Name { get; private set; }
        public MarkType Mark { get; private set; }

        public Player(string name, MarkType mark)
        {
            Name = name;
            Mark = mark;
        }
    }

}
