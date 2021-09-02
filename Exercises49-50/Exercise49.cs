using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises49_50
{
    class Exercise49
    {
        static void Main(string[] args)
        {
            string cont = "y";
            
            while(cont == "y")
            {
                string sideLength = string.Empty;
                bool check = true;
                List<Square> squares = new List<Square>();
                List<int> squareSideLength = new List<int>();
                List<double> squarePerimeter = new List<double>();
                List<double> squareArea = new List<double>();

                while (check == true)
                {
                    Console.WriteLine("Please enter a side length (q to quit): ");
                    sideLength = Console.ReadLine();
                    if(sideLength == "q")
                    {
                        break;
                    }


                    int side;

                    bool isParsable = int.TryParse(sideLength, out side);

                    if (isParsable)
                    {
                        Square newSquare = new Square();
                        newSquare.SideLength = side;
                        newSquare.Perimeter = side * 4;
                        newSquare.Area = side * side;
                        squares.Add(newSquare);
                        squareSideLength.Add(newSquare.SideLength);
                        squarePerimeter.Add(newSquare.Perimeter);
                        squareArea.Add(newSquare.Area);
                    }
                    else
                    {
                        Console.WriteLine("Your input was invalid.");
                    }
                }
                int largest = squareSideLength.Max();
                int smallest = squareSideLength.Min();
                double averagePerimeter = squarePerimeter.Sum() / squarePerimeter.Count();
                double averageArea = squareArea.Sum() / squareArea.Count();
                int count = squares.Count();

                Console.WriteLine($"You created {count} squares.");
                Console.WriteLine($"Largest: {largest}");
                Console.WriteLine($"Smallest: {smallest}");
                Console.WriteLine($"Average Area: {averageArea}");
                Console.WriteLine($"Average Perimeter: {averagePerimeter}");

                Console.WriteLine("Would you like to continue? (y/n)");
                cont = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Thank you for using our software. Goodbye");
        }
    }
}
