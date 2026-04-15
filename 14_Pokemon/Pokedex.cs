using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections;

namespace _14_Pokemon
{
    internal class Pokedex : IEnumerable<Pokemon>
    {
        List<Pokemon> pokemons;

        public Pokedex()
        {
            pokemons = new List<Pokemon>();
        }
        public IEnumerator<Pokemon> GetEnumerator()
        {
            return pokemons.GetEnumerator();
        }
      
        public bool AddPokemon(Pokemon pokemon)
        {
            if (pokemon == null) return false;
            if (pokemon.HP <= 0 ||
                pokemon.Speed <= 0 ||
                pokemon.Strength <= 0 ||
                this.pokemons.Any(p => p.Name == pokemon.Name)) return false;

            this.pokemons.Add(pokemon);
            return true;
        }
        public bool RemovePokemon(Pokemon pokemon)
        {
            return this.pokemons.Remove(pokemon);
        }

        public void Sort() { pokemons.Sort(); }
        public void Sort(IComparer<Pokemon> comparer) { pokemons.Sort(comparer); }

        public Pokemon FastestPokemon()
        {
            pokemons.Sort(new PokemonComparatorSpeed());
            return pokemons[0];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public override string ToString()
        {
            pokemons.Sort();

            return $"There are {pokemons.Count} pokemons:\r\n" +
                $"{String.Join('\n', pokemons)}";
        }
    }
}
