using System;
using System.Text;
namespace OOP
{
	/*
	Write a class with all the logic needed to convert a phrase to its acronym.
	Techies love their TLA (Three Letter Acronyms)!
	Help generate some jargon by writing a program that converts 
	a long name like Portable Network Graphics to its acronym (PNG).
	*/

    public class Acronym
    {
        public Acronym(string phrase)
        {
            PrintResult(phrase);
   
        }

		public void PrintResult(string phrase)
		{
            Console.WriteLine(this.AcronymBuilder(phrase));
        }
     

        public string AcronymBuilder(string phrase)
        {
            int indexSpace;

			StringBuilder myStringBuilder = new StringBuilder();

			StringBuilder newString = new StringBuilder();

            myStringBuilder.Append(phrase);


			newString.Append(myStringBuilder[0]);

			while (myStringBuilder.ToString().IndexOf(' ') != -1)
			{
				indexSpace = myStringBuilder.ToString().IndexOf(' ');
				newString.Append(myStringBuilder[indexSpace + 1]);
				myStringBuilder = myStringBuilder.Remove(0, indexSpace + 1);
			}

            return newString.ToString();
        }



    }
}
