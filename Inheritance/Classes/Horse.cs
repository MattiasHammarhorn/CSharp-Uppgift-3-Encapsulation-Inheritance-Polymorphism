namespace Inheritance.Classes
{
    public class Horse : Animal
    {
        public bool CanSleepWhileStanding { get; set; }

        public Horse(string name, double weight, int age, bool canSleepWhileStanding) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            CanSleepWhileStanding = canSleepWhileStanding;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: NEIGH!");
        }

        public override string Stats()
        {
            return base.Stats() + $"\t\tCan sleep while standing: {CanSleepWhileStanding}";
        }
    }
}
