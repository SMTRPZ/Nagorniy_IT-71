namespace Newt_Salamander.Cells
{
    public abstract class CellHandler
    {
        public CellHandler Successor;
        public abstract Cell GetCell(Animal animal);
    }
}