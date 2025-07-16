using System.ComponentModel.Design;

namespace Assignment2._4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int xCoordinate = 0;// Initialize xCoordinate to 0
            int yCoordinate = 0;

            Console.WriteLine("Enter the X coordinate:");
            int.TryParse(Console.ReadLine(), out xCoordinate);// Try to parse the input as an integer
            Console.WriteLine("Enter the Y coordinate:");
            int.TryParse(Console.ReadLine(), out yCoordinate);

            if (xCoordinate > 0 && yCoordinate > 0)// Check if the point is in the first quadrant
            {
                Console.WriteLine("The coordinate point " + $"({xCoordinate}, {yCoordinate}) is in the first quadrant.");
            }
            else if (xCoordinate < 0 && yCoordinate > 0)
            {
                Console.WriteLine("The coordinate point " + $"({xCoordinate}, {yCoordinate}) is in the second quadrant.");
            }
            else if (xCoordinate < 0 && yCoordinate < 0) 
            {
                Console.WriteLine("The coordinate point " + $"({xCoordinate}, {yCoordinate}) is in the third quadrant.");
            }
            else if (xCoordinate > 0 && yCoordinate < 0)
            {
                Console.WriteLine("The coordinate point " + $"({xCoordinate}, {yCoordinate}) is in the fourth quadrant.");
            }
            else if (xCoordinate == 0 && yCoordinate == 0) // Check if the point is at the origin
            {
                Console.WriteLine("The coordinate point is at the origin.");
            }
        }
    }
}