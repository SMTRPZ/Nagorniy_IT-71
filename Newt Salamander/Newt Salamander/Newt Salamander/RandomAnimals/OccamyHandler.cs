using Newt_Salamander.Animals;

namespace Newt_Salamander.RandomAnimals
{
    public class OccamyHandler : AnimalHandler
    {
        public override Animal GetAnimal(int chance)
        {
            if (chance <= 3)
            {
                return new Occamy(100, System.Guid.NewGuid().ToString());
            }
            else
            {
                return Successor.GetAnimal(chance);
            }
        }
    }
}
