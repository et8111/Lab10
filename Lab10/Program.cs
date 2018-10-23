using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    class Program
    {
        static int RUN(int count)
        {
            string c = "";
            Console.Write("\nEnter radius: ");
            if(!double.TryParse(Console.ReadLine(), out double temp))
            {
                Console.WriteLine("BAD NUBMER");
                return RUN(count);
            }
            else
            {
            Circle newCircle = new Circle(temp);
            Console.WriteLine("CIRCUMFREENCE: " + newCircle.CalculateFormattedCircumference());
            Console.WriteLine("AREA: " + newCircle.CalculateFormattedArea());
            Console.Write("enter 'n' to go again: ");
            c = Console.ReadLine().ToLower();

            if (c != "n")
                return RUN(count)+1;
            }
            return count+1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nYou created " + RUN(0) + " circles, sick.");
        }
    }
}
