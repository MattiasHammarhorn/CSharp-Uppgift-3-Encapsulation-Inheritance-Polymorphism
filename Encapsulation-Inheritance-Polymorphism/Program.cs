using System;
using System.Collections.Generic;
using System.Reflection;

namespace Encapsulation_Inheritance_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonHandler personHandler = new PersonHandler();

            // Create an instance of Person and catch eventual exceptions in a try-catch block
            /*Person testPerson = new Person();
            try
            {
                // A Person's public properties are reachable throughout the project
                testPerson.Age = 18;
                Console.WriteLine($"testPerson.Age set manually: {testPerson.Age}");
                testPerson.FName = "Test";
                testPerson.LName = "Testingsson";
                testPerson.Height = 169;
                testPerson.Weight = 73;
                
                personHandler.SetAge(testPerson, 19);
                Console.WriteLine($"testPerson.Age after SetAge(): {testPerson.Age}");

                personHandler.DisplayPersonalInformation(testPerson);
            }
            catch (ArgumentException ex)
            {
                // A Person's property defines an ArgumentException Message in the set accessor
                Console.WriteLine(ex.Message);
            }*/

            //Instantiate persons through the PersonHandler class
            Person p1 = personHandler.CreatePerson(34, "Karl", "Gustaf", 180, 82);
            Person p2 = personHandler.CreatePerson(6, "Yasin", "Köroglu", 112, 82);
            Person p3 = personHandler.CreatePerson(17, "Daniella", "Lindström", 112, 82);
            Person p4 = personHandler.CreatePerson(28, "Abebe", "Gebremariam", 169, 64);

            personHandler.persons.Add(p1);
            personHandler.persons.Add(p2);
            personHandler.persons.Add(p3);
            personHandler.persons.Add(p4);

            Console.WriteLine();

            // Test methods on objects created through the PersonHandler class
            for (int i = 0; i < personHandler.persons.Count(); i++)
            {
                int y = i + 1;
                Person person = personHandler.persons[i];
                personHandler.DisplayPersonalInformation(person);
                personHandler.SetAge(person, y);
                personHandler.SetFName(person, $"Test-{y}");
                personHandler.SetLName(person, $"Testingsson-{y}");
                personHandler.SetHeight(person, 160 + y);
                personHandler.SetWeight(person, 70 + y);
                personHandler.DisplayPersonalInformation(person);
            }
        }
    }
}
