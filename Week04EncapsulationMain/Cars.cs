using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04EncapsulationMain
{
    internal class Cars // This class encapsulates the properties of a car and restricts the door count to only 2 or 4.
    {
        public string Brand { get; set; } // The brand of the car, e.g., Toyota, Honda
        public string Model { get; set; } // The model of the car, e.g., Corolla, Civic
        public string Color { get; set; } // The color of the car, e.g., Red, Blue
        private int _doorCount { get; set; } // The number of doors on the car, which can only be 2 or 4    
        public int DoorCount // Property to get or set the number of doors, with validation
        {
            get // This getter returns the current door count
            {
                return _doorCount;
            }
            set // This setter allows setting the door count, but only to valid values (2 or 4)
            {
                if (value ==2 || value == 4)
                {
                    _doorCount = value;

                }
                else
                {
                    _doorCount = -1; // Set to an invalid value 
                }
            }
        }
        public Cars(string brand, string model, string color, int doorCount) // Constructor to initialize the car's properties
        {
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorCount; // This will invoke the setter
        }
        public void ShowDetails() // Method to display the car's details
        {
            Console.Write($"Brand: {Brand}, Model: {Model}, Color: {Color}, Doors: {DoorCount}");

            if (DoorCount == -1)
            {
                Console.Write("  --> Your choice is unavailable! (Only 2 or 4 doors allowed)");
            }

            Console.WriteLine(); 
        }

    }
}
