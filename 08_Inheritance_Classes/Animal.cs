using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public enum DietType { Herbivore = 1, Omnivore, Carnivore, Vegan }
    public class Animal
    {
        public int NumberOfLegs { get; set; }
        public bool HasFur { get; set; }
        public bool BreathsAir { get; set; }
        public DietType TypeOfDiet { get; set; }

        public Animal() { }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
