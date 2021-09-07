using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficJam
{
    public class Car
    {
        public readonly string id;
        // public Map map;


        // ORIGIN
        private int xPos;
        public int XPos
        {
            get { return xPos; }
            private set { xPos = value; }
        }
        private int yPos;

        public int YPos
        {
            get { return yPos; }
            private set { yPos = value; }
        }

        public readonly int width; // int from 1 to mapwidth, will be multiplied by squaresize
        public readonly int height; // int from 1 to mapwidth, will be multiplied by squaresize
        public readonly Orientation Orientation;



    }
    public enum Orientation
    {
        HORIZONTAL,
        VERTICAL
    }
}
