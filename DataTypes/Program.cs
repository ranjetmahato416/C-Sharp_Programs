// See https://aka.ms/new-console-template for more information
using System;
namespace Ncc.ConsoleApp
{
    public class Program {
        //public static void Main(string[] args)
        public static void Main()
        {
            DataTypes();
            return;
        }
        static void DataTypes(){
            {
                int i = 10;
                // // i=20;
                // float f = 20;

                // //char => int => long => float => double
                // char c = 'C';
                // i = 'C';
                // long l = i;
                // float f2 = l;
                // double d = f;

                // f = (float)d;
                // l = (long)f;
                // i = (int)l;
                // c = (char)i;
                



                // Console.WriteLine(i);
                // Console.WriteLine(i);
                // Console.WriteLine(f);
                // Console.WriteLine(c);
                // Console.WriteLine(l);
                // Console.WriteLine(d);
                // Console.WriteLine(f2);

                // var x;
                // x = 10;

                object o = "";
                o = 1;
                o = 2f;

                 var y = (float)o;
                 Console.WriteLine(y);
                //  var a = "1";
                //  var b = "2";
                  //var keywords are not datatypes, once assigned it cannot be changed.
                //a==b *this will not work

                object o1 = "";
                object o2 = 1;
                o1 = o2; //This will not work

                var ab = i.ToString();
                Console.WriteLine(i);

                // string str = "abc";
                string str = "123";
                // int m = (int)str;
                Console.WriteLine(str);

                int x = Convert.ToInt32(str);
                Console.WriteLine(x);
                
            }
        }
    }
}
