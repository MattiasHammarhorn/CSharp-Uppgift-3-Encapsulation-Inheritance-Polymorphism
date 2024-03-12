using Inheritance.Classes;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>()
            {
                new Wolf("Silver Fang",9,5,10),
                new Worm("Wormie",1,2,5),
                new Dog("Fido",4,5,false),
                new Dog("Cerberus",7,4,false),
                new Horse("Spirit",420,6,true),
                new Wolfman("David Kessler",25,75,10),
                new Hedgehog("Sonic",56,19,730),
                new Pelican("Nigel",13,12,2,3),
                new Swan("An ugly duckling",10,9,2,25000),
                new Flamingo("",3,22,1,true),
            };

            Console.WriteLine("\nLooping through an array of animals and displaying their sounds...\n");
            foreach (var animal in animals)
            {
                animal.DoSound();
                if (animal is IPerson castedToIPerson)  // If it can be cast as an IPerson, do so
                {
                    castedToIPerson.Talk();
                }
            }

            //F: Försök att lägga till en häst i listan av hundar. Varför fungerar inte det?
            //S: Det fungerar inte eftersom att Horse inte ärver av Dog
            List<Dog> dogs = new List<Dog>();
            Horse horsePretendingToBeADog = new Horse("Epona", 5, 6, true);
            //dogs.Add(horsePretendingToBeADog); //Kastar ett compile time error

            //F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans?
            //S: Den måste vara av typen Animal, eftersom det är basklassen som klasserna ärver från

            Console.WriteLine("\nLooping through the array of animals and displaying their stats:\n");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Stats());
            }
            //F: Förklara vad det är som händer.
            //S: Eftersom att Stats()-metoden är definierad på Animal klassen och alla andra
            // klasser i listan ärver från den så kommer vi åt metoden i foreach-loopen.
            // Då X tar Y för alla Z så Å.

            //Skapa en ny metod med valfritt namn i klassen Dog som endast returnerar en valfri
            //sträng. Kommer du åt den metoden från Animals listan?
            //F: Varför inte ?
            //S: Då arv hierarkin i C# endast går nedåt från klass till klass
            Console.WriteLine("\nLooping through the array of animals and displaying their stats ONLY if they're a dog:\n");
            foreach (var animal in animals)
            {
                if (animal is Dog castableDog)
                {
                    Console.WriteLine(animal.Stats());
                    Console.WriteLine(castableDog.Fetch());
                }
            }
        }
    }
}
