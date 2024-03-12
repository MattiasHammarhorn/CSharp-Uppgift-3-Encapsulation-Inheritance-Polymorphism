namespace Inheritance.Classes
{
    public class Swan : Bird
    {
        public int SpecialFeathers { get; set; }

        public Swan(string name, double weight, int age, double wingSpan, int specialFeathers) : base(name, weight, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Age = age;
            WingSpan = wingSpan;
            SpecialFeathers = specialFeathers;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: OO-OO!");
        }
        public override string Stats()
        {
            return base.Stats() + ($"\t\tAmount of special feathers: {SpecialFeathers}");
        }
    }
}
