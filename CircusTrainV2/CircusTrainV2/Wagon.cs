using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainV2
{
    public class Wagon
    {
        private List<Animal> AnimalsInWagon;
        public List<Animal> TestAnimalsInWagon { get { return AnimalsInWagon; } }
        public int MaxPointsInWagon { get; private set; }
        private int CurrentPointsInWagon;
        private int Id;

        public Wagon(int id, int maxPointsInWagon)
        {
            Id = id;
            MaxPointsInWagon = maxPointsInWagon;
            AnimalsInWagon = new List<Animal>();
        }
        public bool AddAnimalToWagonIfPossible(Animal animal)
        {
            if(AnimalsInWagon.Count == 0)
            {
                AnimalsInWagon.Add(animal);
                CurrentPointsInWagon += animal.Points;
            }
            else if(PossibleAddition(animal))
            {
                AnimalsInWagon.Add(animal);
                CurrentPointsInWagon += animal.Points;
            }
            else
            {
                return false;
            }
            return true;
        }
        private bool PossibleAddition(Animal animal)
        {
            bool Possible = true;
            if(CurrentPointsInWagon + animal.Points > MaxPointsInWagon)
            {
                Possible = false;
            }
            if(!AnimalsInWagon[0].CanLiveWith(animal))
            {
                Possible = false;
            }
            return Possible;
        }

        public override string ToString()
        {
            string animalString = "";
            for (int i = 0; i < AnimalsInWagon.Count; i++)
            {
                animalString += AnimalsInWagon[i] + Environment.NewLine;
            }
            return $"wagon {Id} (points:{CurrentPointsInWagon})" + Environment.NewLine + animalString;
        }
    }
}
