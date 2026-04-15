using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pokemon
{
    internal class PokemonComparatorStrength : IComparer<Pokemon>
    {
        public int Compare(Pokemon? x, Pokemon? y)
        {
            return (-1) * x.Strength.CompareTo(y.Strength);
        }
    }
}
