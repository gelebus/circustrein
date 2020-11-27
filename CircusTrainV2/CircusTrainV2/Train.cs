using System;
using System.Collections.Generic;

namespace CircusTrainV2
{
    public class Train
    {
        public Train(List<Animal> animals, int maxPointsPerWagon)
        {
            Animals = animals;
            MaxPointsPerWagon = maxPointsPerWagon;
        }

        private List<Wagon> Wagons;
        private List<Animal> Animals;
        private int MaxPointsPerWagon;
        public int CurrentWagonId;

        public void SortAnimalsInWagons()
        {
            Init();
            SortOrder();
            AddAnimalsToWagons();
        }
        private void Init()
        {
            Wagons = new List<Wagon>();
            CurrentWagonId = 1;
            Wagons.Add(new Wagon(CurrentWagonId, MaxPointsPerWagon));
        }
        private void SortOrder()
        {
            int currentAnimalSpot = 0;
            for (int i = currentAnimalSpot + 1; i < Animals.Count; i++)
            {
                AnimalSwitchChecks(currentAnimalSpot, i);
                if(i == Animals.Count - 1 && currentAnimalSpot != Animals.Count - 1)
                {
                    i = currentAnimalSpot;
                    currentAnimalSpot++;
                }
            }
        }
        private void AnimalSwitchChecks(int currentAnimalSpot, int SwitchAnimalSpot)
        {
            if (Animals[currentAnimalSpot].Diet == Diet.Carnivore)
            {
                if (Animals[currentAnimalSpot].Points < Animals[SwitchAnimalSpot].Points && Animals[SwitchAnimalSpot].Diet == Diet.Carnivore)
                {
                    SwitchAnimals(currentAnimalSpot, SwitchAnimalSpot);
                }
            }
            else
            {
                if (Animals[SwitchAnimalSpot].Diet == Diet.Carnivore)
                {
                    SwitchAnimals(currentAnimalSpot, SwitchAnimalSpot);
                }
                else if (Animals[currentAnimalSpot].Points < Animals[SwitchAnimalSpot].Points && Animals[SwitchAnimalSpot].Diet == Diet.Herbivore)
                {
                    SwitchAnimals(currentAnimalSpot, SwitchAnimalSpot);
                }
            }
        }
        private void SwitchAnimals(int CurrentAnimalSpot, int SwitchAnimalSpot)
        {
            Animal switchAnimal = Animals[CurrentAnimalSpot];
            Animals[CurrentAnimalSpot] = Animals[SwitchAnimalSpot];
            Animals[SwitchAnimalSpot] = switchAnimal;
        }
        private void AddAnimalsToWagons()
        {
            for (int i = 0; i < Animals.Count; i++)
            {  
                if(!WagonAdditionIfPossible(Animals[i]))
                {
                    CurrentWagonId++;
                    Wagons.Add(new Wagon(CurrentWagonId, MaxPointsPerWagon));
                    i -= 1;
                }
            }
        }
        private bool WagonAdditionIfPossible(Animal animal)
        {
            foreach(Wagon wagon in Wagons)
            {
                if(wagon.AddAnimalToWagonIfPossible(animal))
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string wagonString = "";
            for (int i = 0; i < Wagons.Count; i++)
            {
                wagonString += Wagons[i] + Environment.NewLine;
            }
            return wagonString;
        }
    }
}
