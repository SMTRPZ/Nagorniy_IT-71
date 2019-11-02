using System;
using System.Text;
using NewtSalamanderTests;

namespace Newt_Salamander
{
    public abstract class Animal
    {
        protected int weightOfFood;
        protected int WeightOfFood
        {
            set
            {
                if (value <= 0)
                {
                    throw new NumberNegativeOrZeroException();
                }

                weightOfFood = value;
            }
            get { return weightOfFood; }
        }

        private string name;
        private string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new StringEmptyOrNullException();
                }

                name = value;
            }
            get { return name; }
        }

        public Animal(int weightOfFood, string name)
        {
            WeightOfFood = weightOfFood;
            Name = name;
        }
        public abstract string Voice();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}\n");
            sb.Append($"Weight of food: {WeightOfFood}\n");
            sb.Append($"Voice: {Voice()}\n");
            return sb.ToString();
        }

        public int GetWeightOfFood()
        {
            return WeightOfFood;
        }

        public string GetName()
        {
            return Name;
        }
    }
}