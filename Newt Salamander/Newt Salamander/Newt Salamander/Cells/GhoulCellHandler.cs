using System;
using Newt_Salamander.Animals;

namespace Newt_Salamander.Cells
{
    public class GhoulCellHandler : CellHandler
    {
        public override Cell GetCell(Animal animal)
        {
            return new GhoulCell(System.Guid.NewGuid().ToString());
        }
    }
}