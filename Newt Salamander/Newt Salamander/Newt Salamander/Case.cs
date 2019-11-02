using Newt_Salamander.Cells;
using Newt_Salamander.RandomAnimals;
using System.Collections.Generic;
using System.Text;

namespace Newt_Salamander
{
    public class Case
    {
        private static Case _case;
        private RandomAnimal randomAnimal;
        private List<Cell> cells;
        private bool isDay;

        private Case()
        {
            isDay = true;
            cells = new List<Cell>();
            randomAnimal = new RandomAnimal();
        }

        public static Case GetInstance()
        {
            if (_case == null)
            {
                _case = new Case();
            }
            return _case;
        }

        public Animal AddRandomAnimal()
        {
            Animal animal = randomAnimal.GetRandomAnimal();
            Cell cell = CellForAnimal.GetCellForAnimal(animal);
            cell.PlaceAnimal(animal);
            cells.Add(cell);
            return animal;
        }

        public void AddAnimal(Animal animal)
        {
            Cell cell = CellForAnimal.GetCellForAnimal(animal);
            cell.PlaceAnimal(animal);
            cells.Add(cell);
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

        public List<Animal> GetAnimals()
        {
            List<Animal> animals = new List<Animal>();
            Animal tempAnimal;
            for (int i = 0; i < GetCells().Count; i++)
            {
                tempAnimal = GetCells()[i].GetAnimal();
                if (tempAnimal != null)
                {
                    animals.Add(tempAnimal);
                }
            }
            return animals;
        }

        public int GetFullWeightOfFood()
        {
            int weight = 0;
            foreach (var animal in GetAnimals())
            {
                weight += animal.GetWeightOfFood();
            }

            return weight;
        }

        public float GetAverageWeightOfFood()
        {
            return ((float)GetFullWeightOfFood() / GetAnimals().Count);
        }

        public string GetAllVoices()
        {
            if (isDay)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var animal in GetAnimals())
                {
                    sb.Append(animal.Voice() + "\n");
                }

                return sb.ToString();
            }
            else
            {
                return "Night, can't get all voices";
            }
        }

        public string GetAnimalsInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var animal in GetAnimals())
            {
                sb.Append(animal.ToString());
            }

            return sb.ToString();
        }

        public string GetCellsInfo()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var cell in GetCells())
            {
                sb.Append(cell.ToString());
            }

            return sb.ToString();
        }

        public string GetVoiceByName(string name)
        {
            List<Animal> animals = GetAnimals();
            foreach (var animal in animals)
            {
                if (animal.GetName() == name)
                {
                    return animal.Voice();
                }
            }

            return "Animal with this name not in case";
        }

        public string ChangeDayNight()
        {
            isDay = !isDay;
            if (isDay)
            {
                return "Day";
            }
            else
            {
                return "Night";
            }
        }

        public void CleanCase()
        {
            cells = new List<Cell>();
        }
    }
}
