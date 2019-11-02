using Newt_Salamander.Animals;

namespace Newt_Salamander.Cells
{
    public class ManticoreCellHandler : CellHandler
    {
        public override Cell GetCell(Animal animal)
        {
            if (animal is Manticore)
            {
                return new ManticoreCell(System.Guid.NewGuid().ToString());
            }

            return Successor.GetCell(animal);
        }
    }
}