using CircusTrainV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CircusTrainTests
{
    [TestClass]
    public class AnimalTests
    {
        [TestMethod]
        public void TwoCarnivoresCantLiveTogether()
        {
            Animal animal1 = new Animal(AnimalSize.Small, Diet.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Small, Diet.Carnivore);

            Assert.IsFalse(animal1.CanLiveWith(animal2));
        }
        [TestMethod]
        public void TwoHervivoresCanLiveTogether()
        {
            Animal animal1 = new Animal(AnimalSize.Small, Diet.Herbivore);
            Animal animal2 = new Animal(AnimalSize.Small, Diet.Herbivore);
           
            Assert.IsTrue(animal1.CanLiveWith(animal2));
        }
        [TestMethod]
        public void ALargerHerbivoreCanLiveWithACarnivore()
        {
            Animal animal1 = new Animal(AnimalSize.Small, Diet.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Middle, Diet.Herbivore);

            Assert.IsTrue(animal1.CanLiveWith(animal2));
        }
        [TestMethod]
        public void ALargerCarnivoreCantLiveWithASmallerHerbivore()
        {
            Animal animal1 = new Animal(AnimalSize.Middle, Diet.Carnivore);
            Animal animal2 = new Animal(AnimalSize.Small, Diet.Herbivore);

            Assert.IsFalse(animal1.CanLiveWith(animal2));
        }
    }
}
