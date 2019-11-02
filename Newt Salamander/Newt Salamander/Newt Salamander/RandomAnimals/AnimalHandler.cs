namespace Newt_Salamander.RandomAnimals
{
    public abstract class AnimalHandler
    {
        public AnimalHandler Successor;
        public abstract Animal GetAnimal(int chance);
    }
}
