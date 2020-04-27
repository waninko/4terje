using System;

namespace animals_classes_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            var platypus = new Mammals("platypus", "..quack?", "Born by eggs");
            //    Console.WriteLine("Get animal charachteristics by looking them up.");
            //    Console.WriteLine("Here is a list of vertebrate animal groups. Choose one and get a list.");
            //
            
            Console.WriteLine(platypus.BirthType()); //må ovverides til eggs
        }
    }
}
