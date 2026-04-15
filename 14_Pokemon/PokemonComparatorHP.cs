using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pokemon
{
    internal class PokemonComparatorHP : IComparer<Pokemon>
    {
        public int Compare(Pokemon? x, Pokemon? y)
        {
            return (-1) * x.HP.CompareTo(y.HP);
        }
    }
}
