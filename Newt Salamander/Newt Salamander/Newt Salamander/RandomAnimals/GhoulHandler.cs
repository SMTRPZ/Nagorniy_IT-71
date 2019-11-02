using Newt_Salamander.Animals;

namespace Newt_Salamander.RandomAnimals
{
    public class GhoulHandler : AnimalHandler
    {
        public override Animal GetAnimal(int chance)
        {
            if (chance <= 7)
            {
                return new Ghoul(50, System.Guid.NewGuid().ToString());
            }
            else
            {
                return Successor.GetAnimal(chance);
            }
        }
    }
}
