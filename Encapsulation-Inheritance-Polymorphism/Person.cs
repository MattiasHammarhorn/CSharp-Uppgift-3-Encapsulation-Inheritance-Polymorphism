using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation_Inheritance_Polymorphism
{
    internal class Person
    {
        private int age;
        private string fName;
        private string lName;
        private int height;
        private int weight;

        public int Age
        {
            get { return age; }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new ArgumentException("Age must contain a number higher than 0.");
                    }
                    else
                    {
                        age = value;
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string FName
        {
            get { return fName; }
            set
            {
                try
                {
                    if (value.Length < 2 || value.Length > 10)
                    {
                        throw new ArgumentException("FName must contain at least 2 characters and can't be longer than 10 characters.");
                    }
                    else
                    {
                        fName = value;
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string LName
        {
            get { return lName; }
            set
            {
                try
                {
                    if (value.Length < 3 || value.Length > 15)
                    {
                        throw new ArgumentException("LName must contain at least 3 characters and can't be longer than 15 characters.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
    }
}
