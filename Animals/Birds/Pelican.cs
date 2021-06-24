using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Pelican : Animal
    {
        public string BodyColor { get; set; }

        public Pelican(string name, double weight, int age, string bodyColor) : base(name, weight, age)
        {
            if (string.IsNullOrEmpty(bodyColor))
            {
                throw new ArgumentException($"'{nameof(bodyColor)}' cannot be null or empty.", nameof(bodyColor));
            }

            BodyColor = bodyColor;

        }

        public override string DoSound()
        {
            return "Aoo Aoo";
        }
        public override string Stats()
        {
            return base.Stats() + $" BodyColor: {BodyColor}";
        }
    }
}
