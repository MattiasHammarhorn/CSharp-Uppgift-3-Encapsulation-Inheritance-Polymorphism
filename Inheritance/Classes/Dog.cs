namespace Inheritance.Classes
{
    public class Dog : Animal
    {
        public bool CanSenseIncomingStorms { get; set; }

        public Dog(string name, double weight, int age, bool canSenseIncomingStorms) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            CanSenseIncomingStorms = canSenseIncomingStorms;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: Woof woof!");
        }

        public override string Stats()
        {
            return base.Stats() + ($"\t\tCan sense incoming storms: {CanSenseIncomingStorms}");
        }

        public string Fetch()
        {
            return "\t\tAaaand.. FETCH!";
        }
    }
}
