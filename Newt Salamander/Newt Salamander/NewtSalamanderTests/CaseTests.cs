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
        public void GetFullWeightOfFood_Add2Animals_GetWeight()
        {
            int firstWeight = 50;
            int secondWeight = 100;
            Case _case = Case.GetInstance();
            _case.CleanCase();
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
            _case.CleanCase();
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
            _case.CleanCase();
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