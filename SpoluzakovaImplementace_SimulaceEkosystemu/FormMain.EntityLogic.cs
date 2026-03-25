using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpoluzakovaImplementace_SimulaceEkosystemu
{
    public partial class FormMain
    {
        int day;
        Entity[,] map;
        List<Plant> plants;
        List<Herbivore> herbivores;
        List<Carnivore> carnivores;

        const double PLANT_GROW_MULTIPLIER = 0.4;                 // 0-1
        const double HERBIVORE_REPRODUCTION_MULTIPLIER = 1;     // 0-1
        const double CARNIVORE_REPRODUCTION_MULTIPLIER = 0.3;   // 0-1

        Entity[,] CreateMap(int width, int height, int plantCount, int herbivoreCount, int carnivoreCount)
        {
            if (plantCount + herbivoreCount + carnivoreCount > width * height)
                throw new Exception("Too many entities. Entity count cannot exceed map area");

            map = new Entity[width, height];

            // BONUS 1
            plants = new List<Plant>();
            while (plantCount > 0)
            {
                int x = random.Next(width);
                int y = random.Next(height);

                if (map[x, y] == null)
                {
                    Plant plant = new Plant(x, y);
                    map[x, y] = plant;
                    plants.Add(plant);
                    plantCount--;
                }
            }
            herbivores = new List<Herbivore>();
            while (herbivoreCount > 0)
            {
                int x = random.Next(width);
                int y = random.Next(height);

                if (map[x, y] == null)
                {
                    Herbivore herbivore = new Herbivore(x, y);
                    map[x, y] = herbivore;
                    herbivores.Add(herbivore);
                    herbivoreCount--;
                }
            }
            carnivores = new List<Carnivore>();
            while (carnivoreCount > 0)
            {
                int x = random.Next(width);
                int y = random.Next(height);

                if (map[x, y] == null)
                {
                    Carnivore carnivore = new Carnivore(x, y);
                    map[x, y] = carnivore;
                    carnivores.Add(carnivore);
                    carnivoreCount--;
                }
            }

            return map;
        }

        private void NextDay()
        {
            foreach (Herbivore herbivore in herbivores.ToList()) //.ToList() tam musi byt, aby to neprojizdelo list co se meni
            {
                Kill(plants.Count > 0 ? plants[random.Next(plants.Count)] : herbivore);
            }
            foreach (Carnivore carnivore in carnivores.ToList()) //.ToList() tam musi byt ^^
            {
                Kill(herbivores.Count > 0 ? herbivores[random.Next(herbivores.Count)] : carnivore);
            }

            Reproduce(herbivores);
            Reproduce(carnivores);
            GrowPlants();

            day++;
            update();
        }
        private void Kill(Entity entity)
        {
            map[entity.X, entity.Y] = null;
            switch (entity)
            {
                case Plant p: plants.Remove(p); break;
                case Herbivore h: herbivores.Remove(h); break;
                case Carnivore c: carnivores.Remove(c); break;
            }
        }

        // BONUS 2
        private void Reproduce(List<Herbivore> herbivores)
        {
            int children = (int)(HERBIVORE_REPRODUCTION_MULTIPLIER * herbivores.Count() / 2);
            for (int i = 0; i < children; i++)
            {
                if (RandomEmptySpot() is not Point p) return;

                Herbivore herbivore = new Herbivore(p.X, p.Y);
                map[p.X, p.Y] = herbivore;
                herbivores.Add(herbivore);
            }
        }
        private void Reproduce(List<Carnivore> carnivores)
        {
            int children = (int)(CARNIVORE_REPRODUCTION_MULTIPLIER * carnivores.Count() / 2);
            for (int i = 0; i < children; i++)
            {
                if (RandomEmptySpot() is not Point p) return;

                Carnivore carnivore = new Carnivore(p.X, p.Y);
                map[p.X, p.Y] = carnivore;
                carnivores.Add(carnivore);
            }
        }
        // BONUS 3
        private void GrowPlants()
        {
            int sprouts = (int)(PLANT_GROW_MULTIPLIER * random.NextDouble() * EmptyCount()) + 1;
            for (int i = 0; i < sprouts; i++)
            {
                if (RandomEmptySpot() is not Point p) return;

                Plant plant = new Plant(p.X, p.Y);
                map[p.X, p.Y] = plant;
                plants.Add(plant);
            }
        }

        private int EntityCount()
        {
            return plants.Count + herbivores.Count + carnivores.Count;
        }
        private int EmptyCount()
        {
            return map.GetLength(0) * map.GetLength(1) - EntityCount();
        }

        private Point? RandomEmptySpot()
        {
            if (map.GetLength(0) * map.GetLength(1) - EntityCount() <= 0)
                return null;

            int x = random.Next(map.GetLength(0));
            int y = random.Next(map.GetLength(1));
            while (map[x, y] != null)
            {
                x = random.Next(map.GetLength(0));
                y = random.Next(map.GetLength(1));
            }

            return new Point(x, y);
        }
    }
}
