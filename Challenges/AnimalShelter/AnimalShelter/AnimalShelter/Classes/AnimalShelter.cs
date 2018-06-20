using System;
using System.Collections.Generic;
using System.Text;
using AnimalShelter;

namespace AnimalShelter.Classes
{
    public class AnimalsShelter
    {
        /// <summary>
        /// Referencing point that defines the order of AnimalsShelter
        /// </summary>
        public AnimalsShelter Next { get; set; }

        /// <summary>
        /// Value of each AnimalsShelter
        /// </summary>
        public string Value { get; set; }


        /// <summary>
        /// Default set when AnimalsShelter being declared
        /// </summary>
        /// <param name="value"> string of animals</param>
        public AnimalsShelter(string value)
        {
            Value = value;
        }
    }
}
