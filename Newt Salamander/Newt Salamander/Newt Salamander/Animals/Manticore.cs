namespace Newt_Salamander.Animals
{
    public class Manticore : Animal
    {
        public Manticore(int weightOfFood, string name) : base(weightOfFood, name) { }

        public override string Voice()
        {
            return "i'm manticore";
        }
    }
}
