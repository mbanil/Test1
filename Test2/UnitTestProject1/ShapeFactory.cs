using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    public static class ShapeFactory
    {
        public static object GetShape(string choice)
        {
            if (choice == "circle" || choice=="Circle")
            {
                Circle circle = new Circle();
                return circle;
            }
            if (choice == "rectangle" || choice == "Rectangle")
            {
                Rectangle rectangle = new Rectangle();
                return rectangle;
            }
            if(choice== "triangle" || choice == "Triangle")
            {
                Triangle triangle = new Triangle();
                return triangle;                
            }
            if (choice != "circle" || choice != "Circle" || choice != "rectangle" || choice != "Rectangle" || choice != "circle" || choice != "Circle")
                throw new InvalidProgramException("Input a proper choice");
            return null;
        }
    }

    public abstract class Shape
    {
        public double area;
        public abstract Shape CaluclateArea(params double[] data);

        public abstract double Display();
        
    }

    class Circle:Shape
    {      

        public override Shape CaluclateArea(params double[] data)
        {
            if (data == null || data[0] <0)
                throw new IndexOutOfRangeException("Input proper radius");
            area =  3.142 * data[0] * data[0];
            return this;         
        }

        public override double Display()
        {
            Console.WriteLine("The area is of the circle is "+this.area);
            return this.area;
        }
    }

    class Rectangle:Shape
    {
        public override Shape CaluclateArea(params double[] data)
        {
            if (data.Length<2 || data[0] < 0 || data[1]<0)
                throw new IndexOutOfRangeException("Input the proper dimensions");
            area = data[0]*data[1];
            return this;
        }

        public override double Display()
        {
            Console.WriteLine("The area of the Rectangle" + area);
            return this.area;
        }
    }

    class Triangle:Shape
    {
        public override Shape CaluclateArea(params double[] data)
        {
            if (data[0] < 0 || data[1] < 0 || data.Length<2)
                throw new IndexOutOfRangeException("Input the proper dimensions");
            area = data[0] * data[1] * 0.5;
            return this;
        }

        public override double Display()
        {
            Console.WriteLine("The area of the Triangle" + area);
            return this.area;
        }
    }
}
