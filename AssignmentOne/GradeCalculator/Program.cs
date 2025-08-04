using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculateGrade();
        }
        public static void CalculateGrade()
        {
            try
            {
                Console.Write("Enter a numerical grade between 0 and 100: ");

                int grade = Convert.ToInt32(Console.ReadLine());

                if (grade >= 90)
                {
                    Console.WriteLine("Grade A");
                }
                else if (grade >= 80 && grade <= 89)
                {
                    Console.WriteLine("Grade B");
                }
                else if (grade >= 70 && grade <= 79)
                {
                    Console.WriteLine("Grade C");
                }
                else if (grade >= 60 && grade <= 69)
                {
                    Console.WriteLine("Grade D");
                }
                else
                {
                    Console.WriteLine("Grade F");
                }
            }
            catch (Exception )
            {
                Console.WriteLine("Please enter a number");
            }
        }
    }
}
