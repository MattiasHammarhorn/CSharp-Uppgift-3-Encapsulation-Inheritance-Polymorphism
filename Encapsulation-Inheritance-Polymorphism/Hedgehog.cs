using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Inheritance_Polymorphism
{
    public class Hedgehog : Animal
    {
        public int SpeedInMPH { get; set; }

        public Hedgehog(string name, int weight, int age, int speedInMPH) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            SpeedInMPH = speedInMPH;
        }

        public override void DoSound()
        {
            Console.WriteLine("GOTTA GO FAST!");
        }

        public override string Stats()
        {
            return base.Stats() + ($"\t\tSpeed in miles per hour: {SpeedInMPH}");
        }
    }
}
