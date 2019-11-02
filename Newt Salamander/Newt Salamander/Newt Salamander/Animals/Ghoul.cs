namespace Newt_Salamander.Animals
{
    public class Ghoul : Animal
    {
        public Ghoul(int weightOfFood, string name) : base(weightOfFood, name) { }

        public override string Voice()
        {
            return "i'm ghoul";
        }
    }
}
