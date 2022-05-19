using System;
namespace Name{
    public class Square : IShape
    {
        private double length;
        public double Length
        {
            get{
                return length;
            }
        }

        public void GetInput()
        {
            Console.WriteLine("Enter the length of the sqaure.");
            length = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area of Square = {Math.Pow(length,2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of Square = {4*length}");
        }
    }

    public class Rectangle : IShape
    {
        private double length;
        private double breadth;

        public void GetInput()
        {
            Console.WriteLine("Enter the Length of the Rectangle.");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Rectangle.");
            breadth = Convert.ToDouble(Console.ReadLine());

        }

        public void Area()
        {
            Console.WriteLine($"Areaof the Recangle = {length*breadth}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter of Rectangle = {2 * (length+breadth)}");
        }
    }

    public class Circle : IShape
    {
        private double radius;

        public void GetInput()
        {
            Console.WriteLine("Enter the radius of the Circle.");
            radius = Convert.ToDouble(Console.ReadLine());
        }

        public void Area()
        {
            Console.WriteLine($"Area of the Circle = {Math.PI*Math.Pow(radius,2)}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Circumference of Circle = {2*radius}");
        }
    }

    public class EquilateralTriangle : IShape
    {
        public void GetInput()
        {
            throw new NotImplementedException();
        }
        public void Area()
        {
            throw new NotImplementedException();
        }

        public void Perimeter()
        {
            throw new NotImplementedException();
        }
    }
}