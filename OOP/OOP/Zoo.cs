using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    /*
     * Model a ZOO keeping in mind that:
		-   A zoo has a name and a list of animals
		-   At a zoo they can bring new animals and transfer animals to new zoos
		-   At a zoo the animals are daily fed with their favorite food, 
		    and each animal eats what it loves to eat.
		-   Each animal knows to eat by itself, and not all animals of the same type prefer the same type of food. 
		Eg; a horse prefers carrots, and another horse prefers apples
     */

    public class Zoo : Animalz
    {
        public Zoo(string name) 
        {
            Name = name;
        }

        private List<Animalz> animals = new List<Animalz>();

        public List<Animalz> Animals { get { return animals; } }

        public string Name { get; set; }

        public void BringAnimal(Animalz newAnimal)
        {
            animals.Add(newAnimal);
        }


        public static void TransferAnimal(Animalz animalToTransfer, Zoo currentZoo, Zoo newZoo)
        {
            currentZoo.animals.Remove(animalToTransfer);
            newZoo.BringAnimal(animalToTransfer);
        }


        public void FedAnimals()
        {
            foreach (Animalz animal in animals)
            {
                Console.WriteLine($"The animal {animal} is being fed {animal.FavouriteFood}");
            }
        }

    }

    public abstract class Animalz
    {
        public string FavouriteFood { get; set; }

        public void Eat()
        {
            Console.WriteLine("I eat by myself :D");
        }

    }

    public class Horse : Animalz
    {
    }

    public class Zebra : Animalz
    {

    }

	public class Whale : Animalz
	{

	}




}
