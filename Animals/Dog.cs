using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppOOP
{
    class Dog : Animal
    {
        public Dog(string name, double weight, int age, int nrOfTeeth, string ras) : base(name, weight, age)
        {
            NrOfTeeth = nrOfTeeth;
            Ras = ras;
        }

        public int NrOfTeeth { get; set; }
        public string Ras { get; set; }
        public override string DoSound()
        {
            return "Dog säger: Vov Vov";
        }
        public override string Stats()
        {
            return base.Stats() + $" NrOfTeeth: {NrOfTeeth}, Ras: {Ras}";
        }
        public string Eats()
        { return "Makaroner"; }
    }
}
