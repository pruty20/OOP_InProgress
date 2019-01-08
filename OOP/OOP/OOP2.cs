using System;
namespace OOP
{

    /*
    2.Model the Rabbit class knowing that: 
    a rabbit can have Blue, Red or Black eyes
    a rabbit's fur can be white, brown, black or grey
    it has a gender
    has a birth date, and based on that you should be able to see how old the rabbit is
    we also know that a rabbit is a mammal that moves, sleeps and eats certain foods
    */

    public enum EyeColor
	{
		Blue,
		Red,
		Black
	}

	public enum FurColor
	{
		White,
		Brown,
		Black,
		Grey
	}

	public enum Gender
	{
		Male,
		Female
	}

	public class Mammall
	{
        public virtual void WhatAmI()
        {
            Console.WriteLine("I am a Mammall with 2 L's so i don't get in conflicts");
        }
            

	}

    interface IMove
    {
        void Moving();
    }

    interface ISleep
    {
        void Sleeping();
    }

    interface IEat
    {
        void Eating();
    }

    public class Rabbit : Mammall, IMove, ISleep, IEat
	{
		private readonly EyeColor eyeColor;
		private readonly FurColor furColor;
		private readonly Gender gender;
		private readonly DateTime birthDate;

		int age;


		public EyeColor EyeColor
		{
			get { return eyeColor; }
		}


		public FurColor FurColor
		{
			get { return furColor; }
		}


		public Gender Gender
		{
			get { return gender; }
		}


		public DateTime BirthDate
		{
			get { return birthDate; }
		}


		public int Age
		{
			get
			{
				DateTime now = DateTime.Now;
				age = now.Year - birthDate.Year;

				if (now.DayOfYear < birthDate.DayOfYear)
				{
					age--;
				}
				return age;
			}
		}


		public void Moving()
		{
			Console.WriteLine("I am a moving Mammal.");
		}

		public void Sleeping()
		{
			Console.WriteLine("I am a Mammal that sleeps.");
		}

		public void Eating()
		{
			Console.WriteLine("I am a Mammal that eats certain foods");
		}



	}



}

