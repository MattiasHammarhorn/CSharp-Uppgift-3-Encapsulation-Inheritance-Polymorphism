namespace Inheritance.Classes
{
    public class Bird : Animal
    {
        //F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
        //attribut, i vilken klass bör vi lägga det?
        //S: I Bird-klassen eftersom samtliga fåglar ärver från den
        public double WingSpan { get; set; }

        public Bird(string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: Chirp chirp!");
        }

        public override string Stats()
        {
            return base.Stats() + ($"\t\tWingSpan: {WingSpan}");
        }
    }
}
