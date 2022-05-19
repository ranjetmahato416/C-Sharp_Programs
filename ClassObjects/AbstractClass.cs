using System;
namespace Name
{
    public abstract class ShapeAbs
    {
        protected double area;
        protected double perimeter;
        protected abstract void getInput();
        protected abstract void calculate();

        public void GetInput()
        {
            getInput();
            calculate();
        }

        public void Area()
        {
            Console.WriteLine($"Area = {area}");
        }

        public void Perimeter()
        {
            Console.WriteLine($"Perimeter = {perimeter}");
        }
    }

    public class SquareAbs : ShapeAbs
    {
        private double length;
        protected override void getInput()
        {
            Console.WriteLine("Enter the Length of the Square.");
            length = Convert.ToDouble(Console.ReadLine());
        }

        protected override void calculate()
        {
            area = Math.Pow(length,2);
            perimeter = 4*length;
        }


    }

    public class RectangleAbs : ShapeAbs
    {
        private double length;
        private double breadth;
        protected override void calculate()
        {
            area = length * breadth;
            perimeter = 2 * (length + breadth);
        }

        protected override void getInput()
        {
            Console.WriteLine("Enter the Length of the Rectangle.");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Breadth of the Rectangle.");
            breadth = Convert.ToDouble(Console.ReadLine());
        }

    }
}