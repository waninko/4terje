using System;
using System.Collections.Generic;
using System.Text;

namespace _13375p34kGEN
{
    public class TranslateUserInput
    {
        public string ToBeTranslated;
        //lag 2 arrays. ett 13375p34k og ett med bokstaver.
        public string alphabet = "abcdefghijklmnopqrstuvwxyzæøå ";
        string[] leet = {"4", "8", "C" , "D", "3", "F", "6", "H", "1", "J", "K", "1", "M", "N", "0", "P", "Q", "R", "5", "7", "U", "n\\/", "n\\/n\\/", "X" , "Y", "Z", "Æ", "Ø", "Å", " "};

        public TranslateUserInput(string untranslated)
        {
            ToBeTranslated = untranslated;
        }

        public string makeLeet()
        {
            var translatedOutput = "";
            var singleChars =  ToBeTranslated.ToCharArray();
            foreach(char c in singleChars)
            {
                var singleCharTranslation = leet[alphabet.IndexOf(c)];
                translatedOutput += singleCharTranslation;
            }
            return translatedOutput;
        }
    }
}
