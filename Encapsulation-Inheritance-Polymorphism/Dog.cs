using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Inheritance_Polymorphism
{
    public class Dog : Animal
    {
        public bool CanSleepWhileStanding { get; set; }

        public Dog(string name, int weight, int age, bool canSleepWhileStanding) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            CanSleepWhileStanding = canSleepWhileStanding;
        }

        public override void DoSound()
        {
            Console.WriteLine("Woof woof!");
        }

        public override string Stats()
        {
            return base.Stats() + ($"\t\tCan Sleep While Standing: {CanSleepWhileStanding}");
        }

        public string Fetch()
        {
            return "Aaaand.. FETCH!";
        }
    }
}
