using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExercises {
    public delegate string FormatPersonName(string firstName, string lastName);

    public class Person {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintPersonName(FormatPersonName formatter)
        {
           Console.WriteLine(formatter(FirstName, LastName)); 
        }

        public void PrintFullNameLastNameFirst() {
            Console.WriteLine($"{LastName}, {FirstName}");
        }

        public void PrintFullNameAllCaps() {
            Console.WriteLine($"{LastName.ToUpper()}, {FirstName.ToUpper()}");
        }

        public void PrintFullNameLowerCase() {
            Console.WriteLine($"{LastName.ToLower()}, {FirstName.ToLower()}");
        }

        public void PrintShortName() {
            Console.WriteLine($"{FirstName.Substring(0, 1)}. {LastName}");
        }

        public static List<Person> CreateListOfPeople() {
            return new List<Person>()
            {
                new Person() { FirstName = "Stephen", LastName = "King" },
                new Person() { FirstName = "George", LastName = "Martin" },
                new Person() { FirstName = "Ernest", LastName = "Hemingway" },
                new Person() { FirstName = "William", LastName = "Shakespeare" }
            };
        }
    }

    public class PersonUserClass {

        public static string printFullNameLastNameFirst(string firstName, string lastName)
        {
            return $"{lastName.ToUpper()}, {firstName}";
        }

        public static string printFullNameAllCaps(string firstName, string lastName)
        {
            return $"{lastName.ToUpper()}, {firstName.ToUpper()}";
        }
        
       
        public static string PrintLowerCase(string f, string l)
        {
            return $"{l.ToLower()}, {f.ToLower()}";
        }

        public static string PrintShortName(string f, string l)
        {
            return $"{f[0]}. {l}";
        }
        
        public static string FormatLastNameFirst(string firstName, string lastName)
        {
            return $"{lastName}, {firstName}";
        }

        public static string FormatAllCaps(string firstName, string lastName)
        {
            return $"{lastName.ToUpper()}, {firstName.ToUpper()}";
        }

        public static string FormatLowerCase(string firstName, string lastName)
        {
            return $"{lastName.ToLower()}, {firstName.ToLower()}";
        }

        public static string FormatShortName(string firstName, string lastName)
        {
            return $"{firstName.Substring(0, 1)}. {lastName}";
        }
        public static void Main(string[] args) {
            var people = Person.CreateListOfPeople();
            

            ////////////////////////////////
            // Start here            
            ////////////////////////////////
            // Hint:
            // This piece of code
            // foreach (var p in people)
            //     p.PrintFullNameLastNameFirst();
            //  can be translated to
            // people.ForEach(p => p.PrintFullNameLastNameFirst());
            
            // using the ForEach method on List<>. ForEach takes a Lambda as input

            //
            // Problem 1
            // Use this to simplify the foreach statements in the while loop below
            // so they take up only one line each, instead of two
            //
            // Problem 2 (Answer in less than 30 seconds)
            // Did Problem 1 simplify or just make your code harder to read?
            //
            // Problem 3 (May be a hard problem)
            // Give the PersonUserClass class a method PrintFullNameLastNameFirst (copy from Person class)
            // And add a delegate called Formatter to your Person class
            // and a method that takes a this type of delegate as input
            // so this call becomes possible on a person:
            //
            // p.CallDelegate((F, L) => PrintFullNameLastNameFirst(F, L))
            // Use this to translate all your ForEach lines in the while loop to something like
            // people.ForEach(p => p.CallDelegate((F, L) => PrintFullNameLastNameFirst(F, L)));
            //            

            while (true) {
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Hvordan vil du have udskrevet navnene?");
                Console.WriteLine("1: Efternavn efterfulgt af fornavn");
                people.ForEach(p => p.PrintPersonName(printFullNameLastNameFirst));
                
                Console.WriteLine("2: Efternavn efterfulgt af fornavn, store bogstaver");
                people.ForEach(p=> p.PrintPersonName(printFullNameAllCaps));
                Console.WriteLine("3: Efternavn efterfulgt af fornavn, små bogstaver");
                people.ForEach(p => p.PrintPersonName(PrintLowerCase));
                Console.WriteLine("4: Kun forbogstav af fornavn efterfulgt af efternavn");
                people.ForEach(p => p.PrintPersonName(FormatShortName));
                Console.WriteLine();
                Console.WriteLine("q: For at afslutte!");
                Console.Write("> ");
                var input = Console.ReadLine();
                switch (input.ToUpper()) {
                    case "1":
                        people.ForEach(p => p.PrintPersonName(FormatLastNameFirst));
                        break;
                    case "2":
                        people.ForEach(p => p.PrintPersonName(FormatAllCaps));
                        break;
                    case "3":
                        people.ForEach(p => p.PrintPersonName(FormatLowerCase));
                        break;
                    case "4":
                       people.ForEach(p => p.PrintPersonName(FormatShortName));
                        break;
                    case "Q": return;
                    default:
                        Console.WriteLine("Ukendt valg, prøv igen");
                        break;
                }
            }
        }

        
    }
}
