using System;
using System.Collections.Generic;
using System.Text;

namespace myLibrary
{
    public class Animal : IAnimal
    {
        public bool isDog()
        {
            return Specie == "hund" ? true : false;
        }

        public string? Specie { get; set; }

        public Animal(string specie)
        {
            Specie = specie;
        }
    }

}
