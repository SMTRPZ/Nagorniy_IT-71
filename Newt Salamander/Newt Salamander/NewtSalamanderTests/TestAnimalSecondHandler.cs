using Newt_Salamander;
using Newt_Salamander.Animals;
using Newt_Salamander.RandomAnimals;

namespace NewtSalamanderTests
{
    public class TestAnimalSecondHandler : AnimalHandler
    {
        public override Animal GetAnimal(int chance)
        {
            return new Ghoul(100, "ghoul");
        }
    }
}