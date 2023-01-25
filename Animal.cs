using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_oriented_program_that_print_out_characters_of_animals
{
   class Animal
    {
        public string Colour;
        public int Weight;
        public string Animaltype;
    }
    class Dog : Animal
    {
        public Dog(string colour, int weight, string animaltype)
        {
            Colour = colour;
            Weight = weight;
            Animaltype = animaltype;
        }
    }
}
