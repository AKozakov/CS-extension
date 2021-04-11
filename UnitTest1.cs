using System;
using AbstractShape;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAbstractShape
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //Для круга
        public void TestMethodCircleArea()
        {
            double rTest = 1;
            double excepted = 3.1415926535;

            Circle testCircle = new Circle("круг",rTest);

            double result = testCircle.ShapeArea();

            Assert.AreEqual(excepted, result);



        }

        //Для треугольника
        [TestMethod]
        public void TestMethodTriangleArea()
        {
            double firstSide = 3;
            double secondSide = 4;
            double thirdSide = 5;

            double exceptedArea = 6;

            Triangle testTriangle = new Triangle("треугольник", firstSide, secondSide, thirdSide);

            double triangleResult = testTriangle.ShapeArea();

            Assert.AreEqual(exceptedArea,triangleResult);

        }
    }
}
