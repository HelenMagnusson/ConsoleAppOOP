using System;
using System.Collections.Generic;

namespace ConsoleAppOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InitialisationPersons();
                Console.WriteLine("");
                InitialisationWolfMan();
                InitAnimals();
                InitDogs();
                List<Animal> animals = new List<Animal>();
                animals = InitAnimalList(animals);

                Console.WriteLine("");
                Console.WriteLine("Alla djur i listan: ");
                foreach (var item in animals)
                {
                    Console.WriteLine($"Stats: {item.Stats()} Typ: {item.GetType()}");
                }
                Console.WriteLine("");
                Console.WriteLine("Alla hundar i listan: ");
                foreach (var item in animals)
                {
                    if (item.GetType().Equals(typeof(Dog)))
                    {
                        // Dog d = (Dog)item.GetType();
                        //if (item is Dog) { Console.WriteLine(); ((Dog)item).Eats(); }
                        Console.WriteLine($"Stats: {item.Stats()} Typ: {item.GetType()} Eats: {(Dog)item}");
                        Console.WriteLine($"Dog äter: {((Dog)item).Eats()}"); 
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("{0} Ett fel har har inträffat.", e);
            }

        }

        private static void InitDogs()
        {
            List<Dog> dogs = new List<Dog>();
            Dog dog1 = new Dog("Fido", 11, 3, 45, "Schäfer");
            dogs.Add(dog1);
            Dog dog2 = new Dog("Gittan", 1, 2, 4, "Fågelhund");
            dogs.Add(dog2);
            Dog dog3 = new Dog("Vipp", 14, 32, 5, "Vippet");
            dogs.Add(dog3);
            Dog dog4 = new Dog("Taco", 15, 5, 55, "Tax");
            dogs.Add(dog4);
            Horse h = new Horse("Tia", 3, 33, 55);
            //dogs.Add(h); //Cant convert Horse to Dog, alltså olika typer av objekt och listan är en lista av Dogs
            Console.WriteLine();
            Console.WriteLine("Hundlistan: ");
            foreach (var item in dogs)
            {
                Console.WriteLine($"Namn: {item.Name}, Ras: {item.Ras}");
            }
        }

        private static void InitAnimals()
        {
            List<Animal> animals = new List<Animal>();
            animals = InitAnimalList(animals);

            Console.WriteLine("");
            Console.WriteLine("Djur i listan:");
            foreach (var item in animals)
            {
                if (item.GetType().Equals(typeof(Wolfman)))
                {
                    Console.WriteLine($"Typ: {item.GetType()}");
                    //Console.WriteLine("Person finns i listan");
                    //Console.WriteLine(item.Talk());
                    //osäker på detta
                    IPerson p = (IPerson)item;
                    Console.WriteLine(p.Talk());
                }
                else
                {
                    Console.WriteLine($"Typ: {item.GetType()}");
                    Console.WriteLine($"Sound: {item.DoSound()}");
                }
            }

        }

        private static List<Animal> InitAnimalList(List<Animal> animals)
        {
            Dog dog1 = new Dog("Fido", 11, 3, 45, "Schäfer");
            animals.Add(dog1);
            Worm w = new Worm("olle", 4, 3, 12,false);
            animals.Add(w);
            Wolf wolf = new Wolf("Uffe",3,4,"Brun");
            animals.Add(wolf);
            Wolfman wolfman = new Wolfman("Wulfman",3,4,"gul",189);
            animals.Add(wolfman);
            Hedgehog h = new Hedgehog("Hedda", 3, 4, 50000);
            animals.Add(h);
            Bird b = new Bird("Birdie",2,2);
            animals.Add(b);
            Horse horse1 = new Horse("Tindra", 299, 23, 78);
            animals.Add(horse1);
            Pelican pel = new Pelican("Pelle", 1, 2, "Grey");
            animals.Add(pel);
            Swan sw = new Swan("Sven", 1, 22, 12);
            animals.Add(sw);
            Flamingo fl = new Flamingo("Flamman", 1, 12, 188);
            animals.Add(fl);

            Wolfman wm = new Wolfman("Uwe", 3, 44, "Green", 1.67);
            animals.Add(wm);
            return animals;
        }

        private static void InitialisationWolfMan()
        {
            Wolfman wf = new Wolfman("Uffe", 80, 45, "Brun", 200.00);
            Console.WriteLine($"Wolfman säger: {wf.Talk()}");
            Console.WriteLine("");
            Console.WriteLine("Utskrift av Stats:");
            Console.WriteLine(wf.Stats());
            Console.WriteLine("");
            Console.WriteLine("DoSound");
            var flamingo = new Flamingo("Flamman", 12, 3, 105);
            Console.WriteLine("Flamingon säger: " + flamingo.DoSound());
            var svan = new Swan("Svenne", 1, 34, 100);
            Console.WriteLine("De flesta fåglar säger " + svan.DoSound());

        }


        private static void InitialisationPersons()
        {
            Console.WriteLine("PersonHandler:");
            PersonHandler ph = new PersonHandler();
            Person pers = ph.CreatePerson(4, "Pip", "Json", 0.67, 10);
            ph.AddToList(pers);

            Person p = ph.CreatePerson(34, "Ola", "Larsson", 1.67, 50);
            ph.AddToList(p);

            var p2 = ph.CreatePerson(34, "Ulla", "Karlsson", 1.61, 89);
            ph.AddToList(p2);

            foreach (var item in ph.Persons)
            {
                Console.WriteLine($"{item.Fname} {item.Lname}");
            }

        }
    }
}
