using System;
using Week04EncapsulationMain;

class Program // Main method to test the Cars class
{
    static void Main () // This is the entry point of the program
    {
        Cars car1 = new Cars("Toyota", "Corolla", "Red", 4); // Valid value
        Cars car2 = new Cars("Honda", "Civic", "Blue", 3); // Invalid value, will trigger the setter logic

        car1.ShowDetails(); // This will show the valid door count (4)
        car2.ShowDetails(); // This will show the invalid door count (-1)   
    }
}