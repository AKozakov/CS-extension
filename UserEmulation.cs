using System;
using System.Runtime.Remoting.Messaging;
using AbstractShape;


namespace UserShapeAreaEmulation
{
    class UserEmulation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте!\nВведите, пожалуйста, радиус круга: ");
            string userMessage = Console.ReadLine();
            double testdouble = Convert.ToDouble(userMessage);
            Console.WriteLine(testdouble);
            Circle shapeOne = new Circle("круг", testdouble);
            Console.WriteLine("Площадь круга: " + shapeOne.ShapeArea());
            Console.WriteLine("А теперь, пожалуйста, укажите стороны треугольника: ");
            double[] massTriangle = new double[3] {0, 0, 0};
            int counter = 0;
            do
            {
                Console.WriteLine("Для стороны, под номером - " +(counter+1));
                massTriangle[counter] = Convert.ToDouble(Console.ReadLine());
                counter++;
                

            } while (counter < 3);
            Triangle shapeTwo = new Triangle("треугольник", massTriangle[0], massTriangle[1], massTriangle[2]);
            Console.WriteLine("Площадь круга: " + shapeTwo.ShapeArea());
            Console.WriteLine("Спасибо за помощь!\nДо свидания!");
            Console.ReadLine();
        }
    }
}
