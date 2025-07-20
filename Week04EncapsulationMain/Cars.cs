using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04EncapsulationMain
{
    internal class Cars
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        private int _doorCount { get; set; }
        public int DoorCount
        {
            get
            {
                return _doorCount;
            }
            set
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
        public Cars(string brand, string model, string color, int doorCount)
        {
            Brand = brand;
            Model = model;
            Color = color;
            DoorCount = doorCount; // This will invoke the setter
        }
        public void ShowDetails()
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
