using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task area of the triangle

            Console.WriteLine("Area of the Triangle");
            Console.Write("Enter Based of the Triangle: ");
            string basedInput = Console.ReadLine();
            //double based = Convert.ToDouble(Console.ReadLine());
            Double.TryParse(basedInput, out double based);

            Console.Write("Enter width of the Triangle: ");
            string heightInput = Console.ReadLine();
            Double.TryParse(heightInput, out double height);
            //double height = Convert.ToDouble(Console.ReadLine());

            //checker
            /*Console.WriteLine(based);
            Console.WriteLine(height);*/

            double area = AreaCalculation(height, based);

            Console.WriteLine($"The Area of the Triangle with the based of {based} and width of {height} is {area}!");
        }

        static double AreaCalculation(double height, double based)
        {
            const double angle = 0.5;

            double area; 
            area = angle * (height * based);

            return area;
        }
    }
}
