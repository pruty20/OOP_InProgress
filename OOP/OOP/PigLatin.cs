using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class PigLatin
    {
        public PigLatin(string toTranslate)
        {
            Translator(toTranslate);
        }

        private readonly List<string> vowels = new List<string> { "a", "e", "i", "o", "u" };
        private StringBuilder translated = new StringBuilder();

        public string Translated {get { return translated.ToString(); }}


        public void Translator(string toTranslate)
        {
            translated.Append(toTranslate);

            if(vowels.Contains(toTranslate[0].ToString().ToLower()))
            {
                translated.Append("ay");

            }
            else if(!vowels.Contains(toTranslate[0].ToString()))
            {
                translated.Append(toTranslate[0].ToString().ToLower());
                translated.Append("ay");

            }
        }


        public void PrintTranslation()
        {
            Console.WriteLine($"The translation is: {Translated}");
        }


    }

}

