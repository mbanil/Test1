using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestingAreaOfCircle_VerifyingIt_ShouldPassTheTest()
        {
            Shape shape = (Shape)ShapeFactory.GetShape("circle");
            double[] data = { 5 };
            double result = shape.CaluclateArea(data).Display();
            Assert.AreEqual(3.142 * 5 * 5, result, "Incorrect Result");
        }

        [TestMethod]
        public void TestingAreaOfRectangle_VerifyingIt_ShouldPassTheTest()
        {
            Shape shape = (Shape)ShapeFactory.GetShape("rectangle");
            double[] data = { 5, 5 };
            double result = shape.CaluclateArea(data).Display();
            Assert.AreEqual(25, result, "Incorrect Result");
        }

        [TestMethod]
        public void TestingAreaOfTriangle_VerifyingIt_ShouldPassTheTest()
        {
            Shape shape = (Shape)ShapeFactory.GetShape("triangle");
            double[] data = { 5, 10 };
            double result = shape.CaluclateArea(data).Display();
            Assert.AreEqual(25, result, "Incorrect Result");
        }

        [TestMethod, ExpectedException(typeof(InvalidProgramException))]
        public void InvalidInput_VerifyingIt_ThrowsException()
        {
            Shape shape = (Shape)ShapeFactory.GetShape("");
            double[] data = { 5, 10 };
            double result = shape.CaluclateArea(data).Display();
        }

        [TestMethod, ExpectedException(typeof(IndexOutOfRangeException))]
        public void InvalidDimensionsForCircle_VerifyingIt_ThrowsException()
        {
            Shape shape = (Shape)ShapeFactory.GetShape("Circle");
            double[] data = { -9 };
            double result = shape.CaluclateArea(data).Display();
        }

        [TestMethod, ExpectedException(typeof(IndexOutOfRangeException))]
        public void InvalidDimensionsForRectangle_VerifyingIt_ThrowsException()
        {
            Shape shape = (Shape)ShapeFactory.GetShape("Rectangle");
            double[] data = { 1 };
            double result = shape.CaluclateArea(data).Display();
        }

        [TestMethod, ExpectedException(typeof(IndexOutOfRangeException))]
        public void InvalidDimensionsForTriangle_VerifyingIt_ThrowsException()
        {
            Shape shape = (Shape)ShapeFactory.GetShape("Triangle");
            double[] data = { };
            double result = shape.CaluclateArea(data).Display();
        }
    }
}
