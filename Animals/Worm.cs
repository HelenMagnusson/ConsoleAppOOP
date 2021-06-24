using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Worm : Animal
    {
        public float BodyLength { get; set; }
        public bool IsPoisonous { get; set; }

        public Worm(string name, double weight, int age, float bodyLength, bool IsPoisonous) : base(name, weight, age)
        {
            BodyLength = bodyLength;
        }

        public override string DoSound()
        {
            return "No sound";
        }
        public override string Stats()
        {
            return base.Stats() + $" BodyLength: {BodyLength}, IsPoisonous: {IsPoisonous}";
        }
    }
}
