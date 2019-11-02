using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Newt_Salamander.Animals;

namespace Newt_Salamander.Cells
{
    public class OccamyCell : Cell
    {
        public OccamyCell(string name) : base(name)
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
            if (animal is Occamy)
            {
                this.animal = animal;
                return "successfully placed";
            }
            else
            {
                return "Animal must be occamy";
            }
        }
    }
}