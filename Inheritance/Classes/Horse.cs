namespace Inheritance.Classes
{
    public class Horse : Animal
    {
        public bool CanSleepWhileStanding { get; set; }

        public Horse(string name, int weight, int age, bool canSleepWhileStanding) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            CanSleepWhileStanding = canSleepWhileStanding;
        }

        public override void DoSound()
        {
            Console.WriteLine("NEIGH!");
        }

        public virtual string Stats()
        {
            return base.Stats() + $"\t\tCan sleep while standing: {CanSleepWhileStanding}";
        }
    }
}
