using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using GradeCalculator;
using TicketPriceCalculator;
using TriangleTypeIdentifier;


namespace AssignmentOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tWelcome to my First Console App");
            Console.WriteLine("1. Grade Calculator \n2. Ticket Price Calculator \n3. Triangle Type Identifier");
            Console.Write("\nEnter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) {
                case 1:
                    GradeCalculator.Program.CalculateGrade();
                    break;
                case 2:
                    TicketPriceCalculator.Program.CalculateTicketPrice();
                    break;
                case 3:
                    TriangleTypeIdentifier.Program.IdentifyTriangle();
                    break;
            }
        }
    }
}
