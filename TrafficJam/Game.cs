using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class Game : IGame
    {
    }
    public enum Direction
    { 
        UP,
        DOWN,
        LEFT,
        RIGHT
    }

    public enum GameStatus
    {
        OK,
        ERROR,
        WON,
        LOST
    }
}
