namespace Inheritance.Classes
{
    public class Wolf : Animal
    {
        public int HowlingDistance { get; set; }

        public Wolf(string name, int weight, int age, int howlingDistance) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            HowlingDistance = howlingDistance;
        }

        public override void DoSound()
        {
            Console.WriteLine("AWOO!");
        }
        public override string Stats()
        {
            return base.Stats() + ($"\t\tHowling distance: {HowlingDistance}");
        }
    }
}
