﻿using AbstractFactory;
using System;

namespace CSharpDesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! abstract factory");
            AbstractFactory3.Demonstrate();
            Console.WriteLine("\nAbstract Factory 1&2\n");
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            Console.ReadKey();
        }
    }
    abstract class ContinentFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();
    }

    class AfricaFactory : ContinentFactory
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
    class Herbivore { }
    class Wildebeest : Herbivore { }
    abstract class Carnivore
    {
        public abstract void Eat(Herbivore h);
    }
    class Lion : Carnivore
    {
        public override void Eat(Herbivore h)
        {
            Console.WriteLine(this.GetType().Name + " eats " + h.GetType().Name);
        }
    }

    class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(ContinentFactory factory)
        {
            _herbivore = factory.CreateHerbivore();
            _carnivore = factory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}