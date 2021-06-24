using System;
using System.Collections.Generic;

namespace ConsoleAppOOP
{
    internal class PersonHandler
    {
        public List<Person> Persons = new List<Person>();

        public PersonHandler()
        {
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        private  Person AddPerson(int age = 0, string fname = "DefaultFname", string lname = "DefaultLName", double height = 2, int weight = 50)
        {
            var p = new Person();
            p.Age = age;
            p.Fname = fname;
            p.Lname = lname;
            p.Height = height;
            p.Weight = weight;
            //persons.Add(p);
            return p;

        }
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            var p = new Person();
            p.Age = age;
            p.Fname = fname;
            p.Lname = lname;
            p.Height = height;
            p.Weight = weight;
            //persons.Add(p);
            return p;
        }

        internal List<Person> GetPersonList()
        {
            return Persons;
        }
        internal void AddToList(Person pers)
        {
            Persons.Add(pers);
        }
    }
}