using System;
using System.Linq;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var runOrNot = true;
            string[] availableSymbols =
            {
                "+",
                "-",
                "x",
                "/"
            };
            while (runOrNot)
            {
                int firstNumber = 0;
                int secondNumber = 0;
                string chosenSymbol = "";

                Console.WriteLine("Console Kalkulator test!");
                Console.WriteLine("Tast inn første tall - og trykk enter!");
                while (true)
                {
                    try
                    {
                        firstNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input Plese type a number");
                    }
                }

                Console.WriteLine("Velg matematisk operasjon: ");
                Console.WriteLine("+");
                Console.WriteLine("-");
                Console.WriteLine("/");
                Console.WriteLine("x");

                while (true)
                {
                    Console.WriteLine("Skriv inn ønsket symbol og trykk enter");
                    chosenSymbol = Console.ReadLine();
                    if (availableSymbols.Contains(chosenSymbol))break;
                }


                Console.WriteLine("Tast inn ditt andre tall, og trykk enter igjen!");
                while (true)
                {
                    try
                    {
                        secondNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid input Plese type a number");
                    }
                }
               


                if (chosenSymbol == "+")
                {
                    Console.WriteLine(firstNumber + secondNumber);
                }

                if (chosenSymbol == "-")
                {
                    Console.WriteLine(firstNumber - secondNumber);
                }

                if (chosenSymbol == "/")
                {
                    Console.WriteLine(firstNumber / secondNumber);
                }

                if (chosenSymbol == "x")
                {
                    Console.WriteLine(firstNumber * secondNumber);
                }
                Console.WriteLine("Stop? Press Y");
                var userInput = Console.ReadLine();

                if (userInput == "y" || userInput == "Y")
                {
                    runOrNot = false;
                }
            }
        }
    }
}
