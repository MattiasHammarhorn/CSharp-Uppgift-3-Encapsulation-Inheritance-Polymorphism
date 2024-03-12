using System;
using System.Collections.Generic;
using System.Reflection;
using Encapsulation_Inheritance_Polymorphism.ErrorClasses;

namespace Encapsulation_Inheritance_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 3.1) Encapsulation
            PersonHandler personHandler = new PersonHandler();

            // Create an instance of Person and catch eventual exceptions in a try-catch block
            Person testPerson = new Person();
            try
            {
                // A Person's public properties are reachable throughout the project
                testPerson.Age = 18;
                testPerson.FName = "Test";
                testPerson.LName = "Testingsson";
                testPerson.Height = 169;
                testPerson.Weight = 73;
                // Använd den inskickade personens Age property för att sätta personens age-attribut
                // via SetAge-metoden.
                personHandler.SetAge(testPerson, 19);

                personHandler.DisplayPersonalInformation(testPerson);
            }
            catch (ArgumentException ex)
            {
                // A Person's property defines an ArgumentException Message in the set accessor
                Console.WriteLine(ex.Message);
            }

            // Set properties on the Person class using the methods in the PersonHandler class

            //Instantiate persons through the PersonHandler class
            Person p1 = personHandler.CreatePerson(34, "Karl", "Gustaf", 180, 82);
            Person p2 = personHandler.CreatePerson(6, "Yasin", "Köroglu", 112, 82);
            Person p3 = personHandler.CreatePerson(17, "Daniella", "Lindström", 112, 82);
            Person p4 = personHandler.CreatePerson(28, "Abebe", "Gebremariam", 169, 64);

            personHandler.persons.Add(p1);
            personHandler.persons.Add(p2);
            personHandler.persons.Add(p3);
            personHandler.persons.Add(p4);

            // Test methods
            for (int i = 0; i < personHandler.persons.Count(); i++)
            {
                int y = i + 1;
                Person person = personHandler.persons[i];
                personHandler.SetAge(person, y);
                personHandler.SetFName(person, $"Test-{y}");
                personHandler.SetLName(person, $"Testingsson-{y}");
                personHandler.SetHeight(person, 160 + y);
                personHandler.SetWeight(person, 70 + y);
                personHandler.DisplayPersonalInformation(person);
            }
            #endregion

            #region 3.2) Polymorphism

            List<UserError> userErrors = new List<UserError>();
            UserError ue1 = new NumericInputError();
            UserError ue2 = new TextInputError();
            UserError ue3 = new TypeError();
            userErrors.Add(ue1);
            userErrors.Add(ue2);
            userErrors.Add(ue3);

            Console.WriteLine("\nWriting user errors:\n");
            foreach (var ue in userErrors)
            {
                Console.WriteLine(ue.UEMessage());
            }
            #endregion

            #region 3.4) Inheritance
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
            Horse horsePretendingToBeADog = new Horse("Epona",5,6,true);
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
            #endregion
        }
    }
}
