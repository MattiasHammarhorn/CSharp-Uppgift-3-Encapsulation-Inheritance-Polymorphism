using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Encapsulation_Inheritance_Polymorphism.Program;

namespace Encapsulation_Inheritance_Polymorphism
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, int weight, int howlingDistance) : base(name, age, weight, howlingDistance)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("BACK TO THE MEANING...");
        }

        public void Talk()
        {
            Console.WriteLine("...OF WOLF AND MAN!");
        }
    }
}
