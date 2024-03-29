﻿namespace Inheritance.Classes
{
    public class Hedgehog : Animal
    {
        public int SpeedInMPH { get; set; }

        public Hedgehog(string name, double weight, int age, int speedInMPH) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            SpeedInMPH = speedInMPH;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: GOTTA GO FAST!");
        }

        public override string Stats()
        {
            return base.Stats() + ($"\t\tSpeed in miles per hour: {SpeedInMPH}");
        }
    }
}
