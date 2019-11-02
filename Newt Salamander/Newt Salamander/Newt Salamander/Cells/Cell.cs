using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace Newt_Salamander.Cells
{
    public abstract class Cell
    {
        protected Animal animal;

        public List<Cell> cells;

        protected string name;

        public Cell(string name)
        {
            this.name = name;
            cells = new List<Cell>();
        }

        public abstract string PlaceAnimal(Animal animal);
        public void AddCell(Cell component)
        {
            cells.Add(component);
        }
        public void RemoveCell(Cell component)
        {
            cells.Remove(component);
        }
        public List<Cell> GetCells()
        {
            List<Cell> cells = this.cells;
            for (int i = 0; i < this.cells.Count; i++)
            {
                cells.AddRange(this.cells[i].GetCells());
            }

            return cells;
        }

        public Animal GetAnimal()
        {
            return animal;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Cell name: {name}\n");
            sb.Append($"Animal in cell: \n{animal}\n");
            return sb.ToString();
        }
    }
}