using Newt_Salamander;

namespace NewtSalamanderTests
{
    class TestAnimal : Animal
    {
        public TestAnimal(int weightOfFood, string name) : base(weightOfFood, name) { }

        public override string Voice()
        {
            return "testvoice";
        }
    }
}
