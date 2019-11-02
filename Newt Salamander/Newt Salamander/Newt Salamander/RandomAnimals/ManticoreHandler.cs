using Newt_Salamander.Animals;

namespace Newt_Salamander.RandomAnimals
{
    public class ManticoreHandler : AnimalHandler
    {
        public override Animal GetAnimal(int chance)
        {
            return new Manticore(10, System.Guid.NewGuid().ToString());
        }
    }
}
