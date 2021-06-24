using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Wolf : Animal
    {
        public string FurColor { get; set; }
        public Wolf(string name, double weight, int age, string furColor) : base(name, weight, age)
        {
            FurColor = furColor;
        }
        public override string DoSound()
        {
            return "woooooooooo";
        }

        public override string Stats()
        {
            return base.Stats() + $" FurColor: {FurColor}";
        }
    }
}
