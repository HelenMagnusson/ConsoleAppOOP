using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Bird : Animal
    {
        // Om samtliga fåglar behöver ett nytt attribut, skriv det här.
        public float WingSpan { get; set; }
        public Bird(string name, double weight, int age) : base(name, weight, age)
        {
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string DoSound()
        {
            return "Kvittelikvitt";
        }
        public override string Stats()
        {
            return base.Stats() + $" WingSpan: {WingSpan}";
        }
    }
}
