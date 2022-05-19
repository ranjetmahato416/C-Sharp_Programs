// See https://aka.ms/new-console-template for more information
using System;
namespace Name
{
    
 class Book
 {
     //variables
     public string title;
     public string author;
     public int date;
     public Book(string aTitle, string aAuthor, int aDate)
     {
         title = aTitle;
         author = aAuthor;
         date = aDate;
         
     }
     //constructors:- 1. special functions
     //2. can be called only onlce in its lifetime i.e. during the instantitation of the class
     //3. Name should be same as that of className.
     //4. Does not have a return type i.e. does not return 
     //5. Can be overoaded
     //

     //destructors
     //functions / methods

     //delegates and events
 }

 public class NonStaticClass{
     public int i = 10;
     public static int istatic = 10;
     public void FunctionOne(){
        //  staticfn();
        i++;
        istatic++;
        Console.WriteLine($"i = {i} & istatic = {istatic}");

     }
     public static void staticfn(){
         Console.WriteLine(istatic);
     }
     public NonStaticClass(){

     }

 }
 public static class staticClass{
     public static int i = 10;
     public static void FunctionOne(){

     }
     static staticClass(){

     }

 }

}