using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPriceCalculator
{
    public class Program
    {
        static void Main(string[] args)
        {
            CalculateTicketPrice();
        }
        public static void CalculateTicketPrice()
        {
            try
            {
                Console.Write("Welcome to The Movie Theater Ticket App \nEnter your age: ");

                int age = Convert.ToInt32(Console.ReadLine());
                if (age <= 12 || age >= 65)
                {
                    Console.WriteLine("Your ticket costs GHC 7.");
                }
                else
                {
                    Console.WriteLine("Your ticket costs GHC 10");
                }
            }
            catch (Exception )
            {

                Console.WriteLine("Please enter a number");
            }
        }
    }
}
