using System;
using System.Collections.Generic;
using System.Security.Policy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newt_Salamander;
using Newt_Salamander.Animals;
using Newt_Salamander.Cells;

namespace NewtSalamanderTests
{
    [TestClass]
    public class CellTests
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void PlaceAnimalNull_SetNull_GetException()
        {
            Cell cell = new TestCell("string");
            cell.PlaceAnimal(null);
        }

        [TestMethod]
        public void PlaceAnimalOnce_SetAnimal_GetAnimal()
        {
            Cell cell = new TestCell("string");
            Animal animal = new TestAnimal(10, "testanimal");
            cell.PlaceAnimal(animal);
            Assert.AreEqual(animal, cell.GetAnimal());
        }

        [TestMethod]
        public void PlaceAnimalTwice_SetTwoAnimals_GetFirstAnimal()
        {
            Cell cell = new TestCell("string");
            Animal first = new TestAnimal(10, "first");
            Animal second = new TestAnimal(10, "second");
            cell.PlaceAnimal(first);
            cell.PlaceAnimal(second);
            Assert.AreNotEqual(second, cell.GetAnimal());
        }

        [TestMethod]
        public void PlaceAnimalInvalidType_SetGhoul_GetErrorString()
        {
            Cell cell = new TestCell("string");
            Animal ghoul = new Ghoul(10, "first");
            Assert.AreEqual("Animal must be testanimal", cell.PlaceAnimal(ghoul));
        }

        [TestMethod]
        public void AddCell_ContainsCell_True()
        {
            Cell super = new TestCell("base");
            Cell child = new TestCell("child");
            super.AddCell(child);
            Assert.IsTrue(super.cells.Contains(child));
        }

        [TestMethod]
        public void RemoveCell_ContainsCell_False()
        {
            Cell super = new TestCell("base");
            Cell child = new TestCell("child");
            super.cells = new List<Cell>() { child };
            super.RemoveCell(child);
            Assert.IsFalse(super.cells.Contains(child));
        }

        [TestMethod]
        public void GetCells_SetCellsWithField_GetWithMethod()
        {
            Cell super = new TestCell("base");
            Cell child = new TestCell("child");
            super.cells = new List<Cell>() { child };
            Assert.AreEqual(super.cells, super.GetCells());
        }

        [TestMethod]
        public void GetCellForAnimal_SetAnimal_GetValidCell()
        {
            Animal animal = new Ghoul(10, "ghoul");
            Cell cell = CellForAnimal.GetCellForAnimal(animal);
            Assert.IsTrue(cell is GhoulCell);
        }
    }
}