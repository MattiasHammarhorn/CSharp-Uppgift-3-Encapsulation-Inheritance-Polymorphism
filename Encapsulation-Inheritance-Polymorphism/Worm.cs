using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Inheritance_Polymorphism
{
    public class Worm : Animal
    {
        public int Grenades { get; set; }
        public Worm(string name, int weight, int age, int grenades) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Grenades = grenades;
        }

        public override void DoSound()
        {
            Console.WriteLine("*Wriggle noise*");
        }

        public override string Stats()
        {
            return base.Stats() + ($"\t\tAmount of grenades: {Grenades}");
        }
    }
}
