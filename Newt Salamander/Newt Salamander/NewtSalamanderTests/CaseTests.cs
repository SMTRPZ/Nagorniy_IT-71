using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newt_Salamander;
using Newt_Salamander.Animals;
using Newt_Salamander.Cells;

namespace NewtSalamanderTests
{
    [TestClass]
    public class CaseTests
    {
        [TestMethod]
        public void GetAnimals_SetAnimalsWithField_GetEqualByMethod()
        {
            Case _case = Case.GetInstance();
            _case.animals = new List<Animal>() { };
            _case.AddAnimal(new Ghoul(123, "ghoul"));
            Assert.AreEqual(_case.animals[0], _case.GetAnimals()[0]);
        }

        [TestMethod]
        public void AddRandomAnimal_ContainsGhoulOrOccamyOrManticore_True()
        {
            Case _case = Case.GetInstance();
            _case.animals = new List<Animal>();
            _case.AddRandomAnimal();
            Animal randomAnimal = _case.GetAnimals().First();
            Assert.IsTrue(randomAnimal is Ghoul ||
                          randomAnimal is Occamy ||
                          randomAnimal is Manticore);
        }

        [TestMethod]
        public void AddCell_AddGhoulContainsGhoulCell_True()
        {
            Case _case = Case.GetInstance();
            _case.AddAnimal(new Ghoul(123, "ghoul"));
            Assert.IsTrue(_case.cells.Last() is GhoulCell);
        }

        [TestMethod]
        public void GetCells_SetCellsWithFieldCheckWithMethodIfEquals_True()
        {
            Case _case = Case.GetInstance();
            _case.cells = new List<Cell>() { new GhoulCell("ghoulcell") };
            Assert.AreEqual(_case.cells, _case.GetCells());
        }

        [TestMethod]
        public void GetFullWeightOfFood_Add2Animals_GetWeight()
        {
            int firstWeight = 50;
            int secondWeight = 100;
            Case _case = Case.GetInstance();
            _case.AddAnimal(new Ghoul(firstWeight, "ghoul"));
            _case.AddAnimal(new Occamy(secondWeight, "occamy"));
            Assert.AreEqual(_case.GetFullWeightOfFood(), firstWeight + secondWeight);
        }

        [TestMethod]
        public void GetAverageWeightOfFood_Add2Animals_GetWeight()
        {
            int firstWeight = 50;
            int secondWeight = 100;
            float expected = (firstWeight + secondWeight) / 2;
            Case _case = Case.GetInstance();
            _case.AddAnimal(new Ghoul(firstWeight, "ghoul"));
            _case.AddAnimal(new Occamy(secondWeight, "occamy"));
            Assert.AreEqual(expected,_case.GetAverageWeightOfFood());
        }

        [TestMethod]
        public void GetAllVoices_Add2Animals_GetVoices()
        {
            string voiceGhoul = "i'm ghoul";
            string voiceOccamy = "i'm occamy";
            string expected = voiceGhoul + "\n" + voiceOccamy + "\n";
            Case _case = Case.GetInstance();
            _case.AddAnimal(new Ghoul(50, "ghoul"));
            _case.AddAnimal(new Occamy(100, "occamy"));
            Assert.AreEqual(expected, _case.GetAllVoices());
        }

        [TestMethod]
        public void GetVoiceByName_AddAnimal_GetVoice()
        {
            string name = "weird";
            Animal animal = new Ghoul(50, name);
            Case _case = Case.GetInstance();
            _case.AddAnimal(animal);
            string expected = "i'm ghoul";
            Assert.AreEqual(expected, _case.GetVoiceByName(name));
        }

        [TestMethod]
        public void GetVoiceByName_AddAnimal_GetErrorString()
        {
            string name = "weird";
            string anotherName = "normal";
            Animal animal = new Ghoul(50, name);
            Case _case = Case.GetInstance();
            _case.AddAnimal(animal);
            string expected = "Animal with this name not in case";
            Assert.AreEqual(expected, _case.GetVoiceByName(anotherName));
        }
    }
}