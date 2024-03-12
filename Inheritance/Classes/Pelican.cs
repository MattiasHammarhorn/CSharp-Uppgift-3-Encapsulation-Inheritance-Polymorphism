namespace Inheritance.Classes
{
    public class Pelican : Bird
    {
        public int GallonsOfWater { get; set; }

        public Pelican(string name, double weight, int age, double wingSpan, int gallonsOfWater) : base(name, weight, age, wingSpan)
        {
            Name = name;
            Weight = weight;
            Age = age;
            WingSpan = wingSpan;
            GallonsOfWater = gallonsOfWater;
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: SQUAWK SQUAWK!");
        }
        public override string Stats()
        {
            return base.Stats() + ($"\t\tGallons of water it can store in its mouth: {GallonsOfWater}");
        }
    }
}
