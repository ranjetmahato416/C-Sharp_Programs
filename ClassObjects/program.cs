using System;
namespace Name
{
    
 class Program {
     static void Main(string[] args)
     {
        //  ClassObjectExample();
        // PropertiesExample();
        // staticClass sc = new staticClass();  // not valid
        // ClassExamples();
        // InheritanceExample();
        // PolyMorphismExample();
        // EnumsExample();
        // ShapesExample(); //Interface class Design
        // ShapesExampleV2(); //Abstract Class Design
        // FunctionExamples(); //Types of Functions
        // ThreadsExample();
        ExceptionHandlingExample();
        

     }

    public static void ExceptionHandlingExample()
    {
        try{
            Test t1 = new Test();
            t1.Add(2, 4);
            Console.WriteLine("Enter a Number.");
            var num = Convert.ToInt32(Console.ReadLine());
            t1.Add(num, 5);
        }
        catch (Exception err)
        {
            Console.WriteLine(err.Message);
        }

    }

     private static void ThreadsExample()
     {
         ParallelProgramming pp = new ParallelProgramming();
         pp.Run();
     }


     private static void FunctionExamples()
     {
         Functions f1 = new Functions();
         f1.FunctionTwo(1, "");
         f1.FunctionTwo(b:"", a: 1);
         f1.FunctionThree(new int[] {1, 2, 3, 4, 5 });
         f1.FunctionFour(1, 2, 3, 4, 5, 6, 7, 8, 9, 10 );
         int result = 0;
         f1.FunctionSix(1, 2, out result);
         Console.WriteLine(result);
         f1.FunctionSeven(1, 2, out result);
         Console.WriteLine(result);
         f1.FunctionEight(2, 4, ref result);
         Console.WriteLine(result);
     }
     private static void ClassExamples()
     {
         var ns = new NonStaticClass();
        var N1 = new NonStaticClass();
        var N2 = new NonStaticClass();
        var N3 = new NonStaticClass();
        N1.FunctionOne();
        N2.FunctionOne();
        N3.FunctionOne();
        NonStaticClass.istatic =20;
        NonStaticClass.staticfn();
     }

     private static void EnumsExample()
     {
         var day = (Days)4;
         var dayNum = (int)day;

         switch(day)
         {
             case Days.Sunday:
             break;
             case Days.Monday:
             break;
             case Days.Tuesday:
             break;
             case Days.Wednesday:
             break;
             case Days.Friday:
             break;
             case Days.Saturday:
             break;
             default:
             break;
         }
         Console.WriteLine(day);
     }


     private static void ShapesExample()
     {
         Console.Write("Enter the choice\n 1.Square\n 2.Rectangle\n 3.Circle\n");
         var choice = Convert.ToInt32(Console.ReadLine());

         var shape = ShapeFactory(choice);
         if(shape == null)
         {
             Console.WriteLine("Invalid Choice.");
             return;
         }

         shape.GetInput();
         shape.Area();
         shape.Perimeter();
     }

     private static IShape ShapeFactory(int choice)
     {
         switch(choice)
         {
             case 1: return new Square();
             case 2: return new Rectangle();
             case 3: return new Circle();
             case 4: return new EquilateralTriangle();
             default : return new EquilateralTriangle();
         }

     }

     private static void ShapesExampleV2()
     {
         Console.WriteLine("Enter the Choice\n1.Square\n2.Rectangle\n");
         var choice = Convert.ToInt32(Console.ReadLine());

         var shape = AbstractShapeFactory(choice);
         if(shape == null)
         {
             Console.WriteLine("Invalid Choice.");
             return;
         }

         shape.GetInput();
         shape.Area();
         shape.Perimeter();
     }

     private static ShapeAbs AbstractShapeFactory(int choice)
     {
         switch(choice)
         {
             case 1: return new SquareAbs();
             case 2: return new RectangleAbs();
             default : return new RectangleAbs();
         }
     }

     private static void InheritanceExample()
     {
         LivingThings l1 = new LivingThings();
         LivingThings l2 = new LivingThings(10);
         Animal a1 = new Animal();
         Animal a2 = new Animal(20);
         Plants p1 = new Plants();
         Plants p2 = new Plants(49);

     }

     private static void PolyMorphismExample()
     {
         LivingThings l1 = new LivingThings();
         LivingThings a1 = new Animal();
         LivingThings p1 = new Plants();
         LivingThings v1 = new Vertibrates();

         l1.Eat();
         a1.Eat();
         p1.Eat();
         v1.Eat();
     }

     private static void ClassObjectExample()
     {
         Book book1 =  new Book("Harry Potter", "J.K. Rowling", 1985);
         Book book2 =  new Book("Lord of the Rings", "Tolkein", 2000);
         

        Console.WriteLine(book1.author);
        Console.WriteLine(book2.title);

     }

     private static void PropertiesExample()
     {
         MarksInfo mi = new MarksInfo();
         mi.MathMarks = 50.45;
         mi.ScienceMarks = 75.45;
         Console.WriteLine($"Total => {mi.Total}");
         Console.WriteLine($"Percentage => {mi.Percentage}%");
         Console.WriteLine($"Division => {mi.Division}");

     }


 }
}