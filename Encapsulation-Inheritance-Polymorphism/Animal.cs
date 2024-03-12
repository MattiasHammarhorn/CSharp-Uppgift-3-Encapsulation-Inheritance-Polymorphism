using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Inheritance_Polymorphism
{
    public abstract class Animal
    {
        //F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        //S: Man skulle lägga det i Animal-klassen eftersom det är basklassen av alla
        // som ärver från den
        public string Name { get; set; }
        public int Weight { get; set; }
        public int Age { get; set; }

        protected Animal(string name, int weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Species: {this.GetType().Name}\t\tName: {Name}\t\tAge: {Age}\t\tWeight: {Weight}";
        }
    }
}
