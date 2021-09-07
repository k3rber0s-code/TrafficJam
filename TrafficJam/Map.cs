using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    class Map
    {
        public readonly string mapName;
        public readonly int mapSize;
        public List<Car> Cars;
        private readonly string fileName;

        public Map(string _fileName, string _mapName, int _mapSize, List<Car> Cars)
        {
            fileName = _fileName;
            mapName = _mapName;
            mapSize = _mapSize;
        }

        internal static Map LoadMapFromFile(string path)
        {
            throw new NotImplementedException();               
        }
    }
}
