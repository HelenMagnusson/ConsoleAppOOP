using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Wolfman : Wolf, IPerson
    {
        public double Height { get; set; }

        public Wolfman(string name, double weight, int age, string furColor, double height) : base(name, weight, age, furColor)
        {
            Height = height;

        }
        public string Talk()
        {
            return "Hello, I am wolfman";
        }

        public override string Stats()
        {
            return base.Stats() + $" Height: {Height}";
        }
    }
}
