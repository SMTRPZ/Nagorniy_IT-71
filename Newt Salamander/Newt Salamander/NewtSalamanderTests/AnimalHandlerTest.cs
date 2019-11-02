using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newt_Salamander;
using Newt_Salamander.Animals;
using Newt_Salamander.RandomAnimals;

namespace NewtSalamanderTests
{
    [TestClass]
    public class AnimalHandlerTest
    {
        [TestMethod]
        public void GetAnimal_SetChance10IsTestAnimal_True()
        {
            int chance = 10;
            AnimalHandler first = new TestAnimalFirstHandler();
            AnimalHandler second = new TestAnimalSecondHandler();
            first.Successor = second;
            Animal testAnimal = first.GetAnimal(chance);
            Assert.IsTrue(testAnimal is TestAnimal);
        }

        [TestMethod]
        public void GetAnimal_SetChance20IsGhoul_True()
        {
            int chance = 20;
            AnimalHandler first = new TestAnimalFirstHandler();
            AnimalHandler second = new TestAnimalSecondHandler();
            first.Successor = second;
            Animal testAnimal = first.GetAnimal(chance);
            Assert.IsTrue(testAnimal is Ghoul);
        }
    }
}