using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoluzakovaImplementace_SimulaceEkosystemu
{
    internal class Entity
    {
        int x, y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }

        public Entity(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
