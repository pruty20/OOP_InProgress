using System;
using System.Text;

namespace OOP
{
    /*
     * Convert a number to a string, the contents of which depend on the number's factors.

        If the number has 3 as a factor, output 'Pling'.
        If the number has 5 as a factor, output 'Plang'.
        If the number has 7 as a factor, output 'Plong'.
        If the number does not have 3, 5, or 7 as a factor, just pass the number's digits straight through.
        Examples

        28's factors are 1, 2, 4, 7, 14, 28.
        In raindrop-speak, this would be a simple "Plong".
        30's factors are 1, 2, 3, 5, 6, 10, 15, 30.
        In raindrop-speak, this would be a "PlingPlang".
        34 has four factors: 1, 2, 17, and 34.
        In raindrop-speak, this would be "34".
     */

    public class RainDrops
    {
        public RainDrops(int toConvert)
        {
            NumberConverter(toConvert);
        }

        public StringBuilder returnString = new StringBuilder();

        public string NumberConverter(int toConvert)
        {
            //int toConvert = 34;


            if (toConvert % 3 == 0 && toConvert % 5 == 0)
            {
                returnString.Append("PlingPlang");
            }
            else if (toConvert % 3 == 0)
            {
                returnString.Append("Pling");
            }
            else if(toConvert % 5 == 0)
            {
                returnString.Append("Plang");
            }


            return returnString.ToString();

        }


    }
}
