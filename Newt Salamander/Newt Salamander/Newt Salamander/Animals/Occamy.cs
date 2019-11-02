namespace Newt_Salamander.Animals
{
    public class Occamy : Animal
    {
        public Occamy(int weightOfFood, string name) : base(weightOfFood, name) { }

        public override string Voice()
        {
           return "i'm occamy";
        }
    }
}
