using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
     class Swan : Bird
    {
        public float NeckLength { get; set; }
        public Swan(string name, double weight, int age, float neckLength) : base(name, weight, age)
        {
            NeckLength = neckLength;
        }
        public override string DoSound()
        {
            return "Kvittkvitt";
        }
        public override string Stats()
        {
            return base.Stats() + $" NeckLength: {NeckLength}";
        }

    }
}
