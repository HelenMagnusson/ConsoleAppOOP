using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Horse : Animal
    {
        public int MaxSpeed { get; set; }

        public Horse(string name, double weight, int age, int maxSpeed) : base(name, weight, age)
        {
            MaxSpeed = maxSpeed;
        }

        public override string DoSound()
        {
            return "Gnägg Gnägg";
        }
        public override string Stats()
        {
            return base.Stats() + $" MaxSpeed: {MaxSpeed}";
        }
    }
}
