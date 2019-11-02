namespace Newt_Salamander.Cells
{
    public static class CellForAnimal
    {
        static CellHandler firstHandler;
        static CellHandler secondHandler;
        static CellHandler lastHandler;


        public static Cell GetCellForAnimal(Animal animal)
        {
            firstHandler = new OccamyCellHandler();
            secondHandler = new ManticoreCellHandler();
            lastHandler = new GhoulCellHandler();

            firstHandler.Successor = secondHandler;
            secondHandler.Successor = lastHandler;

            return firstHandler.GetCell(animal);
        }
    }
}