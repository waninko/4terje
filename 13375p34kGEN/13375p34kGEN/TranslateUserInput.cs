using System;
using System.Collections.Generic;
using System.Text;

namespace _13375p34kGEN
{
    public class TranslateUserInput
    {
        public string ToBeTranslated;
        //lag 2 arrays. ett 13375p34k og ett med bokstaver.
        public string alphabet = "let";
        string[] leet = {"1", "3", "7" };

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
