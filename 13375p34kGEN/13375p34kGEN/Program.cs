using System;
using System.Runtime.InteropServices.ComTypes;

namespace _13375p34kGEN
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prøve å jobbe TDD
            //handle user input - send to transalte class - get back translated
            Console.WriteLine("Hello! Please type in text to translate to 13375p34k.");
            var userinput = Console.ReadLine();
            var handling = new UserInputHandling(userinput);
            var untranslated = handling.UserInputRetrived();
            var translate = new TranslateUserInput(untranslated);
            var output= "";
            Console.WriteLine($"You wrote: {output} ");
        }
    }
}
