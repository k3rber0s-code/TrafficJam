using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    interface IGame
    {
        public int Width { get; set; }
        public List<Car> Cars { get; set; }
        public Vector2 Exit { get; set; }
        public string MapID { get; set; }

        public Car MoveCar(Car selectedCar, Direction direction);
        public bool IsGameOver();
        public GameStatus ResetLevel();
        public GameStatus SkipLevel();
        public GameStatus StartNewGame();


    }
}
