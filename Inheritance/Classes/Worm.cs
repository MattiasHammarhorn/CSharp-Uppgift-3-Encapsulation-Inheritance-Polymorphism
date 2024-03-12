namespace Inheritance.Classes
{
    public class Worm : Animal
    {
        public int Grenades { get; set; }
        public Worm(string name, double weight, int age, int grenades) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            Grenades = grenades;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: *Wriggling noises*");
        }

        public override string Stats()
        {
            return base.Stats() + ($"\t\tAmount of grenades: {Grenades}");
        }
    }
}
