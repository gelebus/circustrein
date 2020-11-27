using System;
using System.Collections.Generic;
using CircusTrainV2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CircusTrainTests
{
    [TestClass]
    public class TrainTests
    {
        private Train train;
        private List<Animal> animals;
        private int maxPointsPerWagon;

        [TestInitialize]
        public void setup()
        {
            animals = new List<Animal>();
            maxPointsPerWagon = 10;
        }

        [TestMethod]
        public void CarnivoresComeInSeperateWagons()
        {
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Middle, Diet.Carnivore));
            train = new Train(animals, maxPointsPerWagon);
            int expected = 2;

            train.SortAnimalsInWagons();

            Assert.AreEqual(expected, train.CurrentWagonId);
        }
        [TestMethod]
        public void HerbivoresCanBeInTheSameWagon()
        {
            animals.Add(new Animal(AnimalSize.Middle, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Large, Diet.Herbivore));
            train = new Train(animals, maxPointsPerWagon);
            int expected = 1;

            train.SortAnimalsInWagons();

            Assert.AreEqual(expected, train.CurrentWagonId);
        }
        [TestMethod]
        public void AHerbivoreCanBeInTheSameWagonAsASmallerCarnivore()
        {
            animals.Add(new Animal(AnimalSize.Middle, Diet.Herbivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Carnivore));
            train = new Train(animals, maxPointsPerWagon);
            int expected = 1;

            train.SortAnimalsInWagons();

            Assert.AreEqual(expected, train.CurrentWagonId);
        }
        [TestMethod]
        public void AHerbivoreCantBeInTheSameWagonAsALargerCarnivore()
        {
            animals.Add(new Animal(AnimalSize.Middle, Diet.Carnivore));
            animals.Add(new Animal(AnimalSize.Small, Diet.Herbivore));
            train = new Train(animals, maxPointsPerWagon);
            int expected = 2;

            train.SortAnimalsInWagons();

            Assert.AreEqual(expected, train.CurrentWagonId);
        }
    }
}
