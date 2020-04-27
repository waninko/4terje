using System;

namespace animals_classes_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var platypus = new Mammals("platypus", "..quack?", "Born by eggs");
            var zebra = new Mammals("zebra", "woop-woop!");
            //    Console.WriteLine("Get animal charachteristics by looking them up.");
            //    Console.WriteLine("Here is a list of vertebrate animal groups. Choose one and get a list.");
            // 
            Console.WriteLine("Want to add an animal to the DB? Please select animal group...");
            Console.WriteLine("1  - Mammal   2 - Amphibian  3 - Reptile  4 - Fish  5 - Bird");
           var userSelectedGroup = Console.ReadLine();
            if(userSelectedGroup == "1")
            Console.WriteLine("You selected ", userSelectedGroup);


            //array of objects, names, sound and exclusive births etc - loop ut i cw's - fra userInputs?
            Console.WriteLine(platypus.BirthType());
            Console.WriteLine($"A zebra is born by: { zebra.BirthType()}, {zebra.Breathe()} and makes the sound {zebra.makeSound()}");
        }
    }
}
