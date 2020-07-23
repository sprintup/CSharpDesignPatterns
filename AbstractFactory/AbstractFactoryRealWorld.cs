using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class AbstractFactoryRealWorld
    {
        public static void Run()
        {
            Console.WriteLine("This real-world code demonstrates the creation of different animal worlds for a computer game using different factories. Although the animals created by the Continent factories are different, the interactions among the animals remain the same.");
            ContinentFactory africa = new AfricaFactory();
            AnimalWorld world = new AnimalWorld(africa);
            world.RunFoodChain();

            ContinentFactory america = new AmericaFactory();
            world = new AnimalWorld(america);
            world.RunFoodChain();
            /*
            Lion eats Wildebeest
            Wolf eats Bison             
             */
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

    class AmericaFactory : ContinentFactory
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
    
    class Bison : Herbivore { }

    class Wolf : Carnivore
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
