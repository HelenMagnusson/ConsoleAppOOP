using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    abstract class Animal
    {
        //Om alla djur behöver ett nytt attribut, skulle man lägga det här!

        public string Name { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }

        //public Animal()
        //{

        //}

        public Animal(string name, double weight, int age)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Weight = weight;
            Age = age;
        }

        public abstract string DoSound();
        public virtual string Stats() 
        { 
            return $"Name: {Name}, Weight: {Weight}, Age: {Age} "; 
        }

 
    }
}
