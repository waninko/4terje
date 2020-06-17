using System;
using System.Collections.Generic;
using System.Text;

namespace _13375p34kGEN
{
    public class UserInputHandling
    {
         string userInput;

        public UserInputHandling(string inputFromConsole)
        {
            userInput = inputFromConsole;
        }

        public bool UserInputRetrived()
        {
           
     
            return userInput != null;

            
        }
    }
}
