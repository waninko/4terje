using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
   public class calculation
    {
        public int FirstNumber;
        public int SecondNumber;
        public string ChosenOperation;

        public void doMaths()
        {
            if (ChosenOperation == "+")
            {
                Console.WriteLine(FirstNumber + SecondNumber);
            }

            if (ChosenOperation == "-")
            {
                Console.WriteLine(FirstNumber - SecondNumber);
            }

            if (ChosenOperation == "/")
            {
                Console.WriteLine(FirstNumber / SecondNumber);
            }

            if (ChosenOperation == "x")
            {
                Console.WriteLine(FirstNumber * SecondNumber);
            }
        }
    }
}
