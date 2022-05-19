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
        EnumsExample();
        

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