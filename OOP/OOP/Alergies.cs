using System;
using System.Collections.Generic;

namespace OOP
{

	/*
        Given a person's allergy score, determine whether or not they're allergic to a given item, and their full list of allergies.
        An allergy test produces a single numeric score which contains the information about all the allergies the person has (that they were tested for).
		The list of items (and their value) that were tested are:

		eggs (1)
		peanuts (2)
		shellfish (4)
		strawberries (8)
		tomatoes (16)
		chocolate (32)
		pollen (64)
		cats (128)
		
		So if Tom is allergic to peanuts and chocolate, he gets a score of 34 (2 - from peanuts + 32 from chocholate)
		Now, given just that score of 34, your program should be able to say:
		Whether Tom is allergic to any one of those allergens listed above.
		All the allergens Tom is allergic to.

		Note: a given score may include allergens not listed above (i.e. allergens that score 256, 512, 1024, etc.). 
		Your program should ignore those components of the score.

		For example, if the allergy score is 257, your program should only report the eggs (1) allergy.
     */


    public enum Items
    {
        eggs = 1,
        peanuts = 2,
		shellfish = 4,
		strawberries = 8,
		tomatoes = 16,
		chocolate = 32,
		pollen = 64,
		cats = 128

    }

    public class PrintClassMethodResults
    {
        public virtual void PrintResults(List<Items> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }


    public class Alergies: PrintClassMethodResults
    {
        public int Score
        {
            get;
            set;
        }

        public Alergies(int Score)
        {
            AlergiesCalculator(Score);
        }


        public List<Items> listAlergies = new List<Items>();

        public List<Items> AlergiesCalculator(int score)
        {
            ifStartLabel:
            if (score == 0)
            {
                return listAlergies;
            }
            if (score < 2)
            {
                listAlergies.Add(Items.eggs);
            }
            else if (score == 2)
            {
                listAlergies.Add(Items.peanuts);
            }
            else if (score < 4)
            {
                listAlergies.Add(Items.peanuts);
                listAlergies.Add(Items.eggs);
            }
            else if (score == 4)
            {
                listAlergies.Add(Items.shellfish);
            }
            else if (score < 8)
            {
                listAlergies.Add(Items.shellfish);
                score = score - 4;
                goto ifStartLabel;
            }
			else if (score == 8)
			{
                listAlergies.Add(Items.strawberries);
			}
            else if (score < 16)
            {
                listAlergies.Add(Items.strawberries);
                score = score - 8;
                goto ifStartLabel;
            }
			else if (score == 16)
			{
				listAlergies.Add(Items.tomatoes);
			}
			else if (score < 32)
			{
				listAlergies.Add(Items.tomatoes);
				score = score - 16;
				goto ifStartLabel;
			}
			else if (score == 32)
			{
                listAlergies.Add(Items.chocolate);
			}
			else if (score < 64)
			{
				listAlergies.Add(Items.chocolate);
				score = score - 32;
				goto ifStartLabel;
			}
			else if (score == 64)
			{
				listAlergies.Add(Items.pollen);
			}
			else if (score < 128)
			{
				listAlergies.Add(Items.pollen);
				score = score - 64;
				goto ifStartLabel;
			}
			else if (score == 128)
			{
				listAlergies.Add(Items.cats);
            }
			else if (score < 256)
			{
				listAlergies.Add(Items.cats);
				score = score - 128;
				goto ifStartLabel;
			}
            else if (score >= 256)
            {
                score = score - 256;
                goto ifStartLabel;
            }

            return listAlergies;
        }
    }
}
