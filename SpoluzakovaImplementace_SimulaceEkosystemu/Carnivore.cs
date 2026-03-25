using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoluzakovaImplementace_SimulaceEkosystemu
{
    internal class Carnivore : Entity
    {
        bool isAlive = true;
        public bool IsAlive { get { return isAlive; } set { isAlive = value; } }

        public Carnivore(int x, int y) : base(x, y) { }
        public Carnivore(int x, int y, bool isAlive) : base(x, y)
        {
            IsAlive = isAlive;
        }
    }
}
