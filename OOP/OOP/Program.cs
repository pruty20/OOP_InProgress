using System;
using System.Text;

namespace OOP
{
	public class MainClass
	{
		public static void Main(string[] args)
		{

            BankAccount myAcc = new BankAccount();



            BankAccount myAcc2 = new BankAccount();

            myAcc.PrintAccountNo();

            myAcc.PrintAccountNo();








        }
	}


	/* 1. Make an application where to model a animals keeping in mind that:
       any kind you model is an animal
       any animal has a name
       there are multiple animal categories like : mammals, fish, birds, reptile, insects
       no matter the category, animal are : flying, walking, swim or crawl.
       depending on the way they move, they have a maximum speed.
       there are animals that can swim and walk (Platypus)
       there are animals that can swim, fly and walk (Wild Duck)
       Not any animal that can fly is a bird, the bat is a mammal that flys, and not evey bird flys - the ostrich is a bird but doesn't fly
    */


	public class Animal
	{
		public string Name { get; set; }

		public Animal(string Name)
		{

		}
	}

	public class Mammal : Animal
	{
		public Mammal(string Name) : base(Name)
		{

		}
	}

	public class Fish : Animal
	{
		public Fish(string Name) : base(Name)
		{

		}
	}

	public class Bird : Animal
	{
		public Bird(string Name) : base(Name)
		{

		}
	}


	public class Reptile : Animal
	{
		public Reptile(string Name) : base(Name)
		{

		}
	}


	public class Insect : Animal
	{
		public Insect(string Name) : base(Name)
		{

		}
	}

	interface IFly
	{

		void Flying();
	}

	interface IWalk
	{
		void Walking();
	}

	interface ISwim
	{
		void Swimming();
	}

	interface ICrawl
	{
		void Crawling();
	}

	interface ISpeed
	{
		int MaximumSpeed { get; set; }
	}




	public class Platypus : Animal, ISwim, IWalk, ISpeed
	{
		public int MaximumSpeed { get; set; }

		public Platypus(string Name) : base(Name)
		{

		}

		public void Swimming()
		{
			Console.WriteLine("I can Swim !");
		}

		public void Walking()
		{
			Console.WriteLine("I can Walk !");
		}
	}


	public class WildDuck : Bird, ISwim, IFly, IWalk, ISpeed
	{
		public int MaximumSpeed { get; set; }

		public WildDuck(string Name) : base(Name)
		{

		}

		public void Swimming()
		{
			Console.WriteLine("I can Swim !");
		}

		public void Flying()
		{
			Console.WriteLine("I can Fly !");
		}

		public void Walking()
		{
			Console.WriteLine("I can Walk !");
		}

	}

	public class Bat : Mammal, IFly, ISpeed
	{
		public int MaximumSpeed { get; set; }

		public Bat(string Name) : base(Name)
		{

		}

		public void Flying()
		{
			Console.WriteLine("I can Fly !");
		}
	}


	public class Ostrich : Bird, IWalk
	{
		public int MaximumSpeed { get; set; }

		public Ostrich(string Name) : base(Name)
		{

		}

		public void Walking()
		{
			Console.WriteLine("I can Walk !");
		}
	}




}