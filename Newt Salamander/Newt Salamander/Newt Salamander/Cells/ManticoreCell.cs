using System;
using System.Collections.Generic;
using Newt_Salamander.Animals;

namespace Newt_Salamander.Cells
{
    public class ManticoreCell : Cell
    {
        public ManticoreCell(string name) : base(name)
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
            if (animal is Manticore)
            {
                this.animal = animal;
                return "successfully placed";
            }
            else
            {
                return "Animal must be manticore";
            }
        }
    }
}