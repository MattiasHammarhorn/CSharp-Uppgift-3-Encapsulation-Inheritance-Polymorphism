using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Encapsulation_Inheritance_Polymorphism
{
    internal class PersonHandler
    {
        public List<Person> persons = new List<Person>();

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public void SetFName(Person pers, string fName)
        {
            pers.FName = fName;
        }

        public void SetLName(Person pers, string lName)
        {
            pers.LName = lName;
        }
        public void SetHeight(Person pers, int height)
        {
            pers.Height = height;
        }
        public void SetWeight(Person pers, int weight)
        {
            pers.Weight = weight;
        }

        public void DisplayPersonalInformation(Person pers)
        {
            Console.WriteLine($"Age: {pers.Age}, Name: {pers.FName} {pers.LName}\nMeasurements: W: {pers.Weight}, H: {pers.Height}");
        }

        public Person CreatePerson(int age, string fname, string lname, int height, int weight)
        {
            Person person = new Person()
            {
                Age = age,
                FName = fname,
                LName = lname,
                Height = height,
                Weight = weight
            };
            return person;
        }
    }
}
