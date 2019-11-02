using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newt_Salamander;
using Newt_Salamander.Animals;
using Newt_Salamander.RandomAnimals;

namespace NewtSalamanderTests
{
    [TestClass]
    public class RandomAnimalTests
    {
        [TestMethod]
        public void GetRandomAnimal_SetChance_GetCorrectAnimal()
        {
            int chanceForOccamy = 2;
            int chanceForGhoul = 5;
            int chanceForManticore = 9;

            RandomAnimal randomAnimal = new RandomAnimal();

            Animal occamy = randomAnimal.GetRandomAnimal(chanceForOccamy);
            Animal ghoul = randomAnimal.GetRandomAnimal(chanceForGhoul);
            Animal manticore = randomAnimal.GetRandomAnimal(chanceForManticore);

            Assert.IsTrue(occamy is Occamy);
            Assert.IsTrue(ghoul is Ghoul);
            Assert.IsTrue(manticore is Manticore);
        }
    }
}