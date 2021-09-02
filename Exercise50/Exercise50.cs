using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise50
{
    class Exercise50
    {
        static void Main(string[] args)
        {
            string cont = "y";


            while(cont == "y")
            {
                List<Triangle> triangles = new List<Triangle>();
                
                bool check = true;
                while(check == true)
                {
                    int inputA, inputB, inputC;
                    string inputAString;
                    Triangle triangle = new Triangle();


                    Console.WriteLine("Enter the side lengths of a triangle (q to quit):");

                    inputAString = Console.ReadLine();
                    if (inputAString == "q")
                    {
                        break;
                    }

                    inputA = int.Parse(inputAString);
                    inputB = int.Parse(Console.ReadLine());
                    inputC = int.Parse(Console.ReadLine());
                    double semiPerimeter = (inputA + inputB + inputC) / 2;
                    double area = Math.Sqrt((semiPerimeter * (semiPerimeter - inputA) * (semiPerimeter - inputB) * (semiPerimeter - inputC)));
                    int perimeter = inputA + inputB + inputC;

                    triangles.Add(triangle);
                    triangle.SideA = inputA;
                    triangle.SideB = inputB;
                    triangle.SideC = inputC;
                    triangle.Area = area;
                    triangle.Perimeter = perimeter;
                }
                double averageArea = triangles.Sum(triangle => triangle.Area) / triangles.Count;
                double averagePerimeter = triangles.Sum(triangle => triangle.Perimeter) / triangles.Count;
                Console.WriteLine($"The average area of your triangles is {averageArea}.");
                Console.WriteLine($"The average perimeter of your triangles is {averagePerimeter}.");
                Console.WriteLine("Would you like to try again (y/n)?");
                cont = Console.ReadLine().ToLower();
            }
            Console.WriteLine("Thank you for using our software. Goodbye!");
        }
    }
}
