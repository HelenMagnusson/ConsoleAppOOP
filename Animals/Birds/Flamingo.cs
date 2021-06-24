using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Flamingo : Bird
    {
        public float Leglength { get; set; }

        public Flamingo(string name, double weight, int age, float leglength) : base(name, weight, age)
        {
            Leglength = leglength;
        }
        public override string DoSound()
        {
            return "ohoh";
        }
        public override string Stats()
        {
            return base.Stats() + $" Leglength: {Leglength}";
        }
    }
}
