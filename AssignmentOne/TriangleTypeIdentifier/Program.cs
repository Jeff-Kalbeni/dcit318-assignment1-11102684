using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            IdentifyTriangle();
        }
        public static void IdentifyTriangle()
        {
            try
            {

                Console.WriteLine("\tEnter three sides of a triangle (lengths)");

                Console.Write("Side 1: ");
                double firstSide = Convert.ToDouble(Console.ReadLine());

                Console.Write("Side 2: ");
                double secondSide = Convert.ToDouble(Console.ReadLine());

                Console.Write("Side 3: ");
                double thirdSide = Convert.ToDouble(Console.ReadLine());

                if (firstSide == secondSide && firstSide == thirdSide && secondSide == thirdSide)
                {
                    Console.WriteLine("This is an equilateral triangle");
                }
                else if (firstSide == secondSide || firstSide == thirdSide || firstSide == thirdSide)
                {
                    Console.WriteLine("This is an isosceles triangle");

                }
                else
                {
                    Console.WriteLine("This is a scalene triangle");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Please enter a number");
            }
        }
    }
}
