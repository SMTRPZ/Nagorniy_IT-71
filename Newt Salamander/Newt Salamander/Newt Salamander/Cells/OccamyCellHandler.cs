using Newt_Salamander.Animals;

namespace Newt_Salamander.Cells
{
    public class OccamyCellHandler : CellHandler
    {
        public override Cell GetCell(Animal animal)
        {
            if (animal is Occamy)
            {
                return new OccamyCell(System.Guid.NewGuid().ToString());
            }

            return Successor.GetCell(animal);
        }
    }
}