using CircusTrainV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CircusTrainTests
{
    [TestClass]
    public class WagonTests
    {
        private List<Animal> animals;
        private Wagon wagon;
        [TestInitialize]
        public void setup()
        {
            wagon = new Wagon(1, 7);
            animals = new List<Animal>();
        }
        [TestMethod]
        public void WagonCantGoOverMaxPoints()
        {
            animals.Add(new Animal(AnimalSize.Middle, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));

            wagon.AddAnimalToWagonIfPossible(animals[0]);

            Assert.IsFalse(wagon.AddAnimalToWagonIfPossible(animals[1]));
        }
        [TestMethod]
        public void WagonCantTakeAnimalsThatCantLiveTogether()
        {
            animals.Add(new Animal(AnimalSize.Large, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            bool CantTakeAnimalsThatCantLiveTogether = true;

            wagon.AddAnimalToWagonIfPossible(animals[0]);
            if (wagon.AddAnimalToWagonIfPossible(animals[1]) || wagon.AddAnimalToWagonIfPossible(animals[2]))
            {
                CantTakeAnimalsThatCantLiveTogether = false;
            }

            Assert.IsTrue(CantTakeAnimalsThatCantLiveTogether);
        }
        [TestMethod]
        public void WagonCanAddAnimalsThatCanLiveTogether()
        {
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Middle, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Middle, Diet.Herbivore));
            
            wagon.AddAnimalToWagonIfPossible(animals[0]);

            Assert.IsTrue(wagon.AddAnimalToWagonIfPossible(animals[1]));
            Assert.IsTrue(wagon.AddAnimalToWagonIfPossible(animals[2]));
        }

        [TestMethod]
        public void AnimalsCanBeAddedToAWagon()
        {
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Middle, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Middle, Diet.Herbivore));
            int expected = 3;

            wagon.AddAnimalToWagonIfPossible(animals[0]);
            wagon.AddAnimalToWagonIfPossible(animals[1]);
            wagon.AddAnimalToWagonIfPossible(animals[2]);

            Assert.AreEqual(expected, wagon.TestAnimalsInWagon.Count);
        }
    }
}
