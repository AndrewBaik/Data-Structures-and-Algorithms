using System;
using System.Collections.Generic;
using System.Text;
using AnimalShelter;

namespace AnimalShelter.Classes
{
    public class Queue
    {
        /// <summary>
        /// AnimalsShelter reference point always facing the first node of the Queue
        /// </summary>
        public AnimalsShelter Front { get; set; }

        /// <summary>
        /// Node reference point always facing the last AnimalsShelter of the Queue
        /// </summary>
        public AnimalsShelter Rear { get; set; }


        /// <summary>
        /// AnimalsShelter reference point used when node is being added or removed
        /// </summary>
        public AnimalsShelter Temp { get; set; }

        /// <summary>
        /// Another AnimalsShelter reference point used when node is being added or removed
        /// </summary>
        public AnimalsShelter Temp2 { get; set; }

        /// <summary>
        /// Default method when declaring the Queue class
        /// </summary>
        /// <param name="animal"></param>
        public Queue(AnimalsShelter animal)
        {
            Front = animal;
            Rear = animal;
            Temp = animal;
        }

        /// <summary>
        /// Method to add a AnimalsShelter to an existing Queue
        /// </summary>
        /// <param name="animal"> AnimalsShelter class being added to an existing Queue </param>
        public void Enqueue(AnimalsShelter animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }

        /// <summary>
        /// Method removing a AnimalsShelter to an existing Queue;
        /// </summary>
        /// <param name="animal"> String either 'cat' or 'dog' to remove from Queue </param>
        /// <returns></returns>
        public AnimalsShelter Dequeue(string animal)
        {
            if(Temp.Value == animal)
            {
                Front = Front.Next;
                Temp.Next = null;
                return Temp;
            }
            while(Temp.Next != null)
            {
                if(animal == Temp.Next.Value)
                {
                    Temp2 = Temp.Next;
                    Temp.Next = Temp.Next.Next;
                    Temp2.Next = null;
                    Temp = Front;
                    return Temp2;
                }
                Temp = Temp.Next;
            }
            Temp = Front;
            Front = Front.Next;
            Temp.Next = null;
            return Temp;
        }

        /// <summary>
        /// Method for displaying purpose in the Console.
        /// </summary>
        public void Print()
        {
            Temp = Front;
            while(Temp != null)
            {
                Console.WriteLine(Temp.Value + "---> ");
                Temp = Temp.Next;
            }
            Console.ReadLine();
        }
    }
}
