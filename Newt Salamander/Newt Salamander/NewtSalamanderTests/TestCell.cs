using System;
using System.Collections.Generic;
using Newt_Salamander;
using Newt_Salamander.Animals;
using Newt_Salamander.Cells;

namespace NewtSalamanderTests
{
    public class TestCell : Cell
    {
        public TestCell(string name) : base(name)
        {
            cells = new List<Cell>();
        }

        public override string PlaceAnimal(Animal animal)
        {
            if (animal == null)
            {
                throw new NullReferenceException();
            }
            if (this.animal != null)
            {
                return "This cell is already taken";
            }
            if (animal is TestAnimal)
            {
                this.animal = animal;
                return "successfully placed";
            }
            else
            {
                return "Animal must be testanimal";
            }
        }
    }
}