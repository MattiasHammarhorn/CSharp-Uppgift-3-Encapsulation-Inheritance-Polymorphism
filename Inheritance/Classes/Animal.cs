namespace Inheritance.Classes
{
    public abstract class Animal
    {
        //F: Om alla djur behöver det nya attributet, vart skulle man lägga det då?
        //S: Man skulle lägga det i Animal-klassen eftersom det är basklassen av alla
        // underklasser som ärver från den
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        protected Animal(string name, double weight, int age)
        {
            Name = name;
            Weight = weight;
            Age = age;
        }

        public abstract void DoSound();

        public virtual string Stats()
        {
            return $"Species: {this.GetType().Name}\t\tName: {Name}\t\tAge: {Age}\t\tWeight: {Weight}";
        }
    }
}
