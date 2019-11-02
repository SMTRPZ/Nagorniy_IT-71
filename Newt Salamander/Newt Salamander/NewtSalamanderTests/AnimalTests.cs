using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newt_Salamander;
using System;

namespace NewtSalamanderTests
{
    [TestClass]
    public class AnimalTests
    { 
        [TestMethod]
        [ExpectedException(typeof(StringEmptyOrNullException))]
        public void NameEmpty_SetEmpty_GetException()
        {
            string emptyString = string.Empty;

            Animal animalWithEmptyName = new TestAnimal(10, emptyString);
        }


        [TestMethod]
        [ExpectedException(typeof(StringEmptyOrNullException))]
        public void NameNull_SetNull_GetException()
        {
            string nullString = null;

            Animal animalWithNullName = new TestAnimal(10, nullString);
        }

        [TestMethod]
        public void NameValid_SetTestName_GetTestName()
        {
            string name = "testname";

            Animal animalWithTestName = new TestAnimal(10, name);

            Assert.AreEqual(name, animalWithTestName.GetName());
        }

        [TestMethod]
        public void FoodWeightValid_Set10_Get10()
        {
            int foodWeight = 10;

            Animal animal = new TestAnimal(foodWeight, "asdf");

            Assert.AreEqual(foodWeight, animal.GetWeightOfFood());
        }

        [TestMethod]
        [ExpectedException(typeof(NumberNegativeOrZeroException))]
        public void FoodWeightNegativeOrZero_SetMinus5And0_GetException()
        {
            int negativeFoodWeight = -5;
            int zeroFoodWeight = 0;

            Animal animalWithNegativeFoodWeight = new TestAnimal(negativeFoodWeight, Guid.NewGuid().ToString());
            Animal animalWithZeroFoodWeight = new TestAnimal(zeroFoodWeight, Guid.NewGuid().ToString());
        }

        [TestMethod]
        public void Voice_Call_GetTestvoice()
        {
            Animal animal = new TestAnimal(10, "asd");
            Assert.AreEqual("testvoice", animal.Voice());
        }
    }
}
