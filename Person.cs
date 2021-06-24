using System;

namespace ConsoleAppOOP
{
    internal class Person : IPerson
    {
        public static int Test { get; set; }
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0) { age = value; } else { throw new ArgumentException("Ålder kan inte vara 0.", nameof(age)); }

            }
        }
        public string Fname
        {
            get
            {
                return fName;
            }
            set
            {
                if (value != "" && value.Length >= 2 && value.Length < 11) { fName = value; } else { throw new ArgumentException("Förnamn måste anges.", nameof(fName)); }

            }
        }
        public string Lname
        {
            get
            {
                return lName;
            }
            set
            {
                if (value != "" && value.Length >= 3 && value.Length < 16) { lName = value; } else { throw new ArgumentException("Efternamn måste anges.", nameof(lName)); }

            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }


        public Person()
        {

        }

        public string Talk()
        {
            return "Person talk";
        }
    }
}