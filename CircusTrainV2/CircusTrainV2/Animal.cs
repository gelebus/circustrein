using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircusTrainV2
{
    public class Animal
    {
        public Animal(AnimalSize size, Diet diet)
        {
            Size = size;
            Diet = diet;
            Points = Convert.ToInt32(size);
        }

        private AnimalSize Size;
        public Diet Diet { get; private set; }
        public int Points { get; private set; }

        public bool CanLiveWith(Animal animal)
        {
            bool CanLiveWithAnimal = true;
            if (Diet == Diet.Carnivore)
            {
                if(animal.Diet == Diet.Carnivore)
                {
                    CanLiveWithAnimal = false;
                }
                else if(animal.Points <= Points)
                {
                    CanLiveWithAnimal = false;
                }
            }
            return CanLiveWithAnimal;
        }

        public override string ToString()
        {
            return $"{Size} {Diet} ({Points})";
        }
    }
}
