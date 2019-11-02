using Newt_Salamander;
using Newt_Salamander.RandomAnimals;

namespace NewtSalamanderTests
{
    public class TestAnimalFirstHandler : AnimalHandler
    {
        public override Animal GetAnimal(int chance)
        {
            if (chance == 10)
            {
                return new TestAnimal(100, "test");
            }
            else
            {
                return Successor.GetAnimal(chance);
            }
        }
    }
}