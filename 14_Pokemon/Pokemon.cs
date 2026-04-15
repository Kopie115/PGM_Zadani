using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Pokemon
{
    internal class Pokemon : IComparable<Pokemon>
    {
        string name, type;
        int hp, speed, strength, level;
        public string Name { get { return name; } set { name = value; } }
        public string Type { get { return type; } set { type = value; } }
        public int HP { get { return hp; } set { hp = value; } }
        public int Speed { get { return speed; } set { speed = value; } }
        public int Strength { get { return strength; } set { strength = value; } }
        public int Level { get { return level; } set { level = Math.Clamp(value, 1, 100); } }

        public Pokemon(string name, string type, int hp, int speed, int strength, int level)
        {
            Name = name;
            Type = type;
            HP = hp;
            Speed = speed;
            Strength = strength;
            Level = level;
        }

        public override string ToString()
        {
            return $"[{type} - lvl {level}] {name}";
        }
        public int CompareTo(Pokemon? other)
        {
            int a = level.CompareTo(other.level);
            return a == 0 ?
                name.CompareTo(other.name) :
                (-a);
        }
    }
}
