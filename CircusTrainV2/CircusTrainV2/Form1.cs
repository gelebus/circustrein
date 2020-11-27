using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircusTrainV2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btAddAnimal_Click(object sender, EventArgs e)
        {
            Diet diet;
            AnimalSize size;
            
            if(btCarnivore.Checked)
            {
                diet = Diet.Carnivore;
            }
            else
            {
                diet = Diet.Herbivore;
            }

            if(btSmall.Checked)
            {
                size = AnimalSize.Small;
            }
            else if(btMiddle.Checked)
            {
                size = AnimalSize.Middle;
            }
            else
            {
                size = AnimalSize.Large;
            }

            lbAnimals.Items.Add(new Animal(size, diet));
        }

        private void btReset_Click(object sender, EventArgs e)
        {
            lbAnimals.Items.Clear();
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            List<Animal> animals = new List<Animal>();
            int maxPointsPerWagon = 10;
            for (int i = 0; i < lbAnimals.Items.Count; i++)
            {
                animals.Add((Animal)lbAnimals.Items[i]);
            }
            Train train = new Train(animals, maxPointsPerWagon);
            train.SortAnimalsInWagons();
            MessageBox.Show(Convert.ToString(train));
        }
    }
}
