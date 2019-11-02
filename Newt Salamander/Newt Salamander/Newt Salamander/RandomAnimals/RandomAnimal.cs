using System;

namespace Newt_Salamander.RandomAnimals
{
    public class RandomAnimal
    {
        AnimalHandler firstHandler;
        AnimalHandler secondHandler;
        AnimalHandler lastHandler;
        int chance;
        Random random;

        public RandomAnimal()
        {
            random = new Random();
            firstHandler = new OccamyHandler();
            secondHandler = new GhoulHandler();
            lastHandler = new ManticoreHandler();

            firstHandler.Successor = secondHandler;
            secondHandler.Successor = lastHandler;
        }

        public Animal GetRandomAnimal()
        {
            chance = random.Next(0, 10);
            return firstHandler.GetAnimal(chance);
        }

        public Animal GetRandomAnimal(int chance)
        {
            return firstHandler.GetAnimal(chance);
        }
    }
}

// DRY not WET - Don't Repeat Yourself not We Enjoying Typing
// TF - When I Grow Up 