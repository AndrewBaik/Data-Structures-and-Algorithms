using System;
using AnimalShelter.Classes;

namespace AnimalShelter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            FIFOAnimalShelter();
        }

        /// <summary>
        /// Example of of Enqueue and Dequeue usage.
        /// </summary>
        public static void FIFOAnimalShelter()
        {
            Queue shelter = new Queue(new AnimalsShelter("dog"));
            shelter.Enqueue(new AnimalsShelter("dog"));
            shelter.Enqueue(new AnimalsShelter("dog"));
            shelter.Enqueue(new AnimalsShelter("cat"));
            shelter.Enqueue(new AnimalsShelter("dog"));

            shelter.Dequeue("cat");
            shelter.Print();
        }
    }
}
