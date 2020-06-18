using System;
using System.Collections.Generic;
using System.Text;

namespace _13375p34kGEN
{
    public class UserInputHandling
    {
         string UserInput;

        public UserInputHandling(string inputFromConsole)
        {
            UserInput = inputFromConsole;
        }

        public string UserInputRetrived()
        {
           if(!String.IsNullOrEmpty(UserInput))
            {
                return UserInput;
            }
            return "no input detected";
     
             

            
        }
    }
}
