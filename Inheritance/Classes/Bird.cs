namespace Inheritance.Classes
{
    public class Bird : Animal
    {
        //F: Om vi under utvecklingen kommer fram till att samtliga fåglar behöver ett nytt
        //attribut, i vilken klass bör vi lägga det?
        //S: I Bird-klassen eftersom samtliga fåglar ärver från den
        public int WingSpan { get; set; }

        public Bird(string name, int weight, int age, int wingSpan) : base(name, weight, age)
        {
            Name = name;
            Weight = weight;
            Age = age;
            WingSpan = wingSpan;
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp chirp!");
        }

        public override string Stats()
        {
            return base.Stats() + ($"\t\tWingSpan: {WingSpan}");
        }
    }

    public class Pelican : Bird
    {
        public int GallonsOfWater { get; set; }

        public Pelican(string name, int weight, int age, int wingSpan, int gallonsOfWater) : base(name, weight, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Age = age;
            WingSpan = wingSpan;
            GallonsOfWater = gallonsOfWater;
        }

        public override void DoSound()
        {
            Console.WriteLine("SQUAWK SQUAWK!");
        }
        public override string Stats()
        {
            return base.Stats() + ($"\t\tGallons of water it can store in its mouth: {GallonsOfWater}");
        }
    }

    public class Flamingo : Bird
    {
        public bool CanFilterFeed { get; set; }

        public Flamingo(string name, int weight, int age, int wingSpan, bool canFilterFeed) : base(name, weight, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Age = age;
            WingSpan = wingSpan;
            CanFilterFeed = canFilterFeed;
        }

        public override void DoSound()
        {
            Console.WriteLine("QUACK QUACK!");
        }
        public override string Stats()
        {
            return base.Stats() + ($"\t\tCan filter feed: {CanFilterFeed}");
        }
    }

    public class Swan : Bird
    {
        public int SpecialFeathers { get; set; }

        public Swan(string name, int weight, int age, int wingSpan, int specialFeathers) : base(name, weight, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Age = age;
            WingSpan = wingSpan;
            SpecialFeathers = specialFeathers;
        }

        public override void DoSound()
        {
            Console.WriteLine("OO-OO!");
        }
        public override string Stats()
        {
            return base.Stats() + ($"\t\tAmount of special feathers: {SpecialFeathers}");
        }
    }
}
