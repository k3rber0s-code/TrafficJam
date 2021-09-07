using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class Game : IGame
    {
        public int Width { get; set; }
        public List<Car> Cars { get; set; }
        public Vector2 ExitPosition { get; set; }
        public string MapID { get; set; }

        public bool MoveCar(Car selectedCar, Direction direction, out Car movedCar)
        {
            throw new NotImplementedException();

        }
        public bool IsGameOver()
        {
            throw new NotImplementedException();

        }
        public GameStatus ResetLevel()
        {
            throw new NotImplementedException();

        }
        public GameStatus SkipLevel()
        {
            throw new NotImplementedException();

        }
        public GameStatus StartNewGame()
        {
            throw new NotImplementedException();

        }
        static Map LoadLevel(string path)
        {
            return Map.LoadMapFromFile(path);
        }
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
