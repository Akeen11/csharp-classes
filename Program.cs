using System;
using System.Collections.Generic;

namespace classes {

    public class Agency {

        // Some readonly properties (let's talk about gets, baby)
        public string Name { get; }
        public DateTime FoundedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Bro> ourHeroes { get; set; }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was Founded

            The constructor will set the value of the public properties
        */
        public Agency(string name, DateTime foundedOn)
        {
            Name = name;
            FoundedOn = foundedOn;
        }
        public void ListBros() {
            foreach(Bro bro in ourHeroes) {
                Console.WriteLine($"{bro.FirstName} {bro.LastName} has been with the {Name} with the quirk of {bro.Title} since {bro.StartDate}.");
            }
        }
    };

    public class Bro {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }

        public Bro (string firstName, string lastName, string title, DateTime startDate) {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            StartDate = startDate;
        }
    }
    class Program {
        static void Main (string[] args) {
            // Create an instance of a company. Name it whatever you like.
            Agency superBros = new Agency("Super Bros", DateTime.Now);

            // Create three employees
            Bro Garrett = new Bro("Garrett", "Kent", "super anime knowledge", DateTime.Now);
            Bro Keith = new Bro("Keith", "Rutkowski", "being a bitch", DateTime.Now);
            Bro Jon = new Bro("Jon", "Riley", "super sleep", DateTime.Now);
            // Assign the employees to the company
            List<Bro> bro = new List<Bro>();

            bro.Add(Garrett);
            bro.Add(Keith);
            bro.Add(Jon);

            superBros.ourHeroes = bro;

            superBros.ListBros();
            

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
        }
    }
}