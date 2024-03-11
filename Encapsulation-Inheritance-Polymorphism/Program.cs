using System;

namespace Encapsulation_Inheritance_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3.1) Encapsulation
            //1.
            Person testPerson = new Person()
            {
                Age = 18,
                FName = "Test",
                LName = "Testingsson",
                Height = 160,
                Weight = 63
            };

            PersonHandler.DisplayPersonalInformation(testPerson);

            //2.
            PersonHandler personHandler = new PersonHandler();
            personHandler.SetAge(testPerson, 47);
            personHandler.SetFName(testPerson, "Hassan");
            personHandler.SetLName(testPerson, "Shahrazade");
            personHandler.SetHeight(testPerson, 170);
            personHandler.SetWeight(testPerson, 73);

            PersonHandler.DisplayPersonalInformation(testPerson);

            //3.
            Person p1 = personHandler.CreatePerson(34, "Karl", "Gustaf", 180, 82);
            Person p2 = personHandler.CreatePerson(6, "Yasin", "Köroglu", 112, 82);
            Person p3 = personHandler.CreatePerson(17, "Daniella", "Lindström", 112, 82);
            Person p4 = personHandler.CreatePerson(28, "Abebe", "Gebremariam", 169, 64);

            personHandler.persons.Add(p1);
            personHandler.persons.Add(p2);
            personHandler.persons.Add(p3);
            personHandler.persons.Add(p4);
            
            //4. & 5.
            foreach (var person in personHandler.persons)
            {
                PersonHandler.DisplayPersonalInformation(person);
            }

            // 3.2) Polymorphism
            // 1.
            List<UserError> userErrors = new List<UserError>();
            UserError ue1 = new NumericInputError();
            UserError ue2 = new TextInputError();
            userErrors.Add(ue1);
            userErrors.Add(ue2);

            foreach (var ue in userErrors)
            {
                Console.WriteLine(ue.UEMessage());
            }

            
        }
    }
}
