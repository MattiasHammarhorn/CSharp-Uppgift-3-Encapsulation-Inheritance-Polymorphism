namespace Inheritance.Classes
{
    public class Flamingo : Bird
    {
        public bool CanFilterFeed { get; set; }

        public Flamingo(string name, double weight, int age, double wingSpan, bool canFilterFeed) : base(name, weight, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Age = age;
            WingSpan = wingSpan;
            CanFilterFeed = canFilterFeed;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: QUACK QUACK!");
        }
        public override string Stats()
        {
            return base.Stats() + ($"\t\tCan filter feed: {CanFilterFeed}");
        }
    }
}
