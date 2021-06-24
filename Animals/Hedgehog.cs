using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public Hedgehog(string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override string DoSound()
        {
            return "nöff";
        }
        public override string Stats()
        {
            return base.Stats() + $" NrOfSpikes: {NrOfSpikes}";
        }
    }
}
