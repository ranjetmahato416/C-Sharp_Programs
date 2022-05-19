// See https://aka.ms/new-console-template for more information
using System;
namespace Name 
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter length and breadth of the rectangle.");
            int lenght = Convert.ToInt32(Console.ReadLine());
            int breadth = Convert.ToInt32(Console.ReadLine());
            AreaOfRectangle(lenght, breadth);
            Perimeter(lenght, breadth);
        }

        public static void AreaOfRectangle(int l, int b)
        {
            int area = l*b;
            Console.WriteLine("Area of Rectangle ="+area);
            
        }

        public static void Perimeter(int x, int y)
        {
            int peri = 2*(x+y); 
        }
    }


}
