using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestProject1;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the input- circle, rectangle or triangle");
                string str = Console.ReadLine();
                Shape shape = (Shape)ShapeFactory.GetShape(str);
                double[] data;
                Console.WriteLine("Enter the dimensions");
                string input = Console.ReadLine();
                data=Array.ConvertAll(input.Split(' '), Double.Parse);
                double result = shape.CaluclateArea(data).Display();
                Console.Read();
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(InvalidProgramException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.Read();                                             
        }
    }

}
