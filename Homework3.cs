using System;
using System.Collections.Generic;

namespace CSHARP
{
    // ===== ABSTRACT PRODUCTS =====
    abstract class Herbivore
    {
        public int Weight { get; set; }
        public bool Life { get; set; } = true;

        public abstract void EatGrass();
    }

    abstract class Carnivore
    {
        public int Power { get; set; }

        public abstract void Eat(Herbivore herbivore);
    }

    // ===== CONCRETE HERBIVORES =====
    class Wildebeest : Herbivore
    {
        public Wildebeest()
        {
            Weight = 50;
        }

        public override void EatGrass()
        {
            Weight += 10;
            Console.WriteLine("Антилопа поела траву вес: " + Weight);
        }
    }

    class Bison : Herbivore
    {
        public Bison()
        {
            Weight = 60;
        }

        public override void EatGrass()
        {
            Weight += 10;
            Console.WriteLine("Бизон поел траву вес: " + Weight);
        }
    }

    // ===== CONCRETE CARNIVORES =====
    class Lion : Carnivore
    {
        public Lion()
        {
            Power = 55;
        }

        public override void Eat(Herbivore herbivore)
        {
            if (!herbivore.Life)
                return;

            if (Power > herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
                Console.WriteLine("Лев съел травоядное животное сила льва: " + Power);
            }
            else
            {
                Power -= 10;
                Console.WriteLine("Лев не смог победить добычу сила льва: " + Power);
            }
        }
    }

    class Wolf : Carnivore
    {
        public Wolf()
        {
            Power = 50;
        }

        public override void Eat(Herbivore herbivore)
        {
            if (!herbivore.Life)
                return;

            if (Power > herbivore.Weight)
            {
                Power += 10;
                herbivore.Life = false;
                Console.WriteLine("Волк съел травоядное животное сила волка: " + Power);
            }
            else
            {
                Power -= 10;
                Console.WriteLine("Волк не смог победить добычу сила волка: " + Power);
            }
        }
    }

    // ===== ABSTRACT FACTORY =====
    abstract class Continent
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    // ===== CONCRETE FACTORIES =====
    class Africa : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Wildebeest();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Lion();
        }
    }

    class NorthAmerica : Continent
    {
        public override Herbivore CreateHerbivore()
        {
            return new Bison();
        }

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }
    }

    // ===== CLIENT =====
    class AnimalWorld
    {
        private List<Herbivore> herbivores = new List<Herbivore>();
        private List<Carnivore> carnivores = new List<Carnivore>();

        public AnimalWorld(Continent continent)
        {
            herbivores.Add(continent.CreateHerbivore());
            carnivores.Add(continent.CreateCarnivore());
        }

        public void MealsHerbivores()
        {
            Console.WriteLine("\nТравоядные начали питаться:");
            foreach (var h in herbivores)
                h.EatGrass();
        }

        public void NutritionCarnivores()
        {
            Console.WriteLine("\nХищники начали охоту:");
            foreach (var c in carnivores)
                foreach (var h in herbivores)
                    if (h.Life)
                        c.Eat(h);
        }
    }

    // ===== MAIN =====
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Африка");
            AnimalWorld africa = new AnimalWorld(new Africa());
            africa.MealsHerbivores();
            africa.NutritionCarnivores();

            Console.WriteLine("\nСеверная Америка");
            AnimalWorld america = new AnimalWorld(new NorthAmerica());
            america.MealsHerbivores();
            america.NutritionCarnivores();

            Console.WriteLine("\nРабота программы завершена.");
        }
    }
}
