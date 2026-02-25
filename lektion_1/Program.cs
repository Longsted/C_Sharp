// See https://aka.ms/new-console-template for more information
using lektion1;
using myLibrary;


Console.WriteLine("Hello, World!");

Person person = new Person("martin");
Console.WriteLine(person.Navn);
person.Navn = "Benny";
Console.WriteLine(person.Navn);

var fido = new Animal("hund");
Console.WriteLine("fido er en hund? " + fido.isDog());