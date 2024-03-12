using System;
using System.Collections.Generic;
using System.Reflection;

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
        }
    }
}
