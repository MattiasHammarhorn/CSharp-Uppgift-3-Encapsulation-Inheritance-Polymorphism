namespace Inheritance.Classes
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double weight, int age, int howlingDistance) : base(name, weight, age, howlingDistance)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine($"{this.GetType().Name} makes this sound: BACK TO THE MEANING...");
        }

        public void Talk()
        {
            Console.WriteLine($"{this.GetType().Name} says: OF WOLF AND MAN!");
        }
    }
}
