using Newt_Salamander.Animals;
using Newt_Salamander.Cells;
using System;
using System.Collections.Generic;

namespace Newt_Salamander
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var _case = Case.GetInstance();

            for (var i = 0; i < 100; i++)
            {
                _case.AddRandomAnimal();
            }

            Animal animal = new Occamy(80, "Jorik");
            _case.AddAnimal(animal);

            Cell cell1 = new GhoulCell("first ghoul");
            Cell cell2 = new ManticoreCell("second manticore");
            Cell cell3 = new OccamyCell("third occamy");
            Cell cell4 = new GhoulCell("fourth ghoul");

            cell1.AddCell(cell2);
            cell2.AddCell(cell3);
            cell2.AddCell(cell4);

            foreach (var cell in cell1.GetCells())
            {
                Console.WriteLine(cell.ToString());
            }

            foreach (var animal_tmp in _case.GetAnimals())
            {
                if (animal_tmp.GetName() == "Jorik")
                {
                    Console.WriteLine(animal_tmp.ToString());
                }
            }

            _case.ChangeDayNight();

            Console.WriteLine(_case.GetFullWeightOfFood());
            Console.WriteLine(_case.GetAverageWeightOfFood());
            Console.WriteLine(_case.GetAllVoices());
            Console.WriteLine(_case.GetAnimalsInfo());
            Console.WriteLine(_case.GetCellsInfo());
            Console.WriteLine(_case.GetVoiceByName("Jorik"));

            Console.Read();
        }
    }
}
