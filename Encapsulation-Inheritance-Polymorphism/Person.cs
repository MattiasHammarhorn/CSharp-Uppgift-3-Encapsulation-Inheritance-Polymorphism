using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Inheritance_Polymorphism
{
    public class Person
    {
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        // Implemented validation in each property which throws an Argument Exception which
        // includes a descriptive error message.
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Age must contain a number higher than 0.\nValue is {value}");
                }
                else
                {
                    age = value;
                }
            }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length < 2 || value.Length > 10)
                {
                    throw new ArgumentException($"FName must contain at least 2 characters and can't be longer than 10 characters.\nValue is {value}");
                }
                else
                {
                    fName = value;
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                if (value.Length < 3 || value.Length > 15)
                {
                    throw new ArgumentException($"LName must contain at least 3 characters and can't be longer than 15 characters.\nValue is {value}");
                }
                else
                {
                    lName = value;
                }
            }
        }
        public double Height
        {
            get{ return height; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height must contain a number higher than 0.\nValue is {value}");
                }
                else
                {
                    height = value;
                }
            }
        }
        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Weight must contain a number higher than 0.\nValue is {value}");
                }
                else
                {
                    weight = value;
                }
            }
        }
    }
}
