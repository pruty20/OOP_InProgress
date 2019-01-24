using System;
using System.Collections.Generic;

namespace OOP
{
	/*
     * Model a ZOO keeping in mind that:
		-   A zoo has a name and a list of animals
		-   At a zoo they can bring new animals and transfer animals to new zoos
		-   At a zoo the animals are daily fed with their favorite food, and each animal eats what it loves to eat. 
		-   Each animal knows to eat by itself, and not all animals of the same type prefer the same type of food. 
		Eg; a horse prefers carrots, and another horse prefers apples
     */

	public class Zoo
    {
        public Zoo()
        {
        }

        private List<string> animals = new List<string>();

		public List<string> Animals { get { return animals; } }

        public string Name
        {
            get;
            set;
        }

        public void BringAnimal(string newAnimal)
        {
            animals.Add(newAnimal);
        }

        public static void TransferAnimals(string animalToTransfer)
        {
            
        }


    }
}
