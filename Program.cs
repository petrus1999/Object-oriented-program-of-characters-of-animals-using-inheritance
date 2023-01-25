using Object_oriented_program_that_print_out_characters_of_animals;

class Program
{
    static void Main(string[] args) {
        Dog dog1 = new Dog("BLACK", 10KG, "PITBULL");
        Dog dog2 = new Dog("WHITE", 30KG, "GERMAN SHERPERD");
        Dog dog3 = new Dog("BROWN", 18KG, "PITBULL");
        Dog dog4 = new Dog("BLACK&WHITE", 25KG, "POODLE");
        Dog dog5 = new Dog("BROWNISH", 27KG, "CHIHUAHUA");
        Dog dog 6 = new Dog("BLACK", 40, "BULLDOG");

        Console.WriteLine(dog1.Colour + " " + dog1.Weight + " " + dog1.Animaltype);
        Console.WriteLine(dog2.Colour + " " + dog2.Weight + " " + dog2.Animaltype);
        Console.WriteLine(dog3.Colour + " " + dog3.Weight + " " + dog3.Animaltype);
        Console.WriteLine(dog4.Colour + " " + dog4.Weight + " " + dog4.Animaltype);
        Console.WriteLine(dog5.Colour + " " + dog5.Weight + " " + dog5.Animaltype);
        Console.WriteLine(dog6.Colour + " " + dog6.Weight + " " + dog6.Animaltype);

    }
    
    
}
