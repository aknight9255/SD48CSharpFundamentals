using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Inheritance_Classes
{
    public class Cat : Animal
    {
        public double ClawLength { get; set; }

        public Cat()
        {
            HasFur = true;
            TypeOfDiet = DietType.Carnivore;
        }

        public override void Move()
        {
            Console.WriteLine($"{GetType().Name} moves quickly");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }

    public class Liger : Cat
    {
        public override void MakeSound()
        {
            Console.WriteLine("Roar");
        }
        public override void Move()
        {
            Console.WriteLine($"the {GetType().Name} stalks its prey.");
            base.Move();
        }
    }

}
