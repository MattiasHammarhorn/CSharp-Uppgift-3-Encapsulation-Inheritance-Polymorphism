namespace Inheritance.Classes
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, int age, int weight, int howlingDistance) : base(name, age, weight, howlingDistance)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("BACK TO THE MEANING...");
        }

        public void Talk()
        {
            Console.WriteLine("...OF WOLF AND MAN!");
        }
    }
}
