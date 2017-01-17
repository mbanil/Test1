using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the input- circle, rectangle or triangle");
            string str = Console.ReadLine();
            Shape shape = (Shape)ShapeFactory.GetShape(str);
            double[] data = { 5 };
            double result = shape.CaluclateArea(data).Display();
            Console.Read();
        }
    }
}
