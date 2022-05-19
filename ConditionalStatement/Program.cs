// See https://aka.ms/new-console-template for more information
using System;
public class Hello
{
    private static void Main()
    {
       ConditionalStatements();
       return;
    }

    private static void ConditionalStatements()
    {
        Console.WriteLine("Enter the day:");
        var choice = Convert.ToInt32(Console.ReadLine());
        string day = "";
        // if(choice == 1) day = "Sunday";
        // else if (choice==2) day = "Monday";
        // else if (choice==3) day = "Tuesday";
        // else if (choice==4) day = "Wednesday";
        // else if (choice==5) day = "Thursday";
        // else if (choice==6) day = "Friday";
        // else if (choice==7) day = "Saturday";
        // else day = "Not a Valid data";

        //switch case
        // switch (choice)
        // {
        //     case 1: day = "Sunday";
        //     break;
        //     case 2: day = "Monday";
        //     break;
        //      case 3:
        //             day = "Tuesday";
        //             break;
        //     case 4:
        //             day = "Wednesday";
        //             break;
        //     case 5:
        //             day = "Thursday";
        //             break;
        //     case 6:
        //             day = "Friday";
        //             break;
        //     case 7:
        //             day = "Saturday";
        //             break;

        //     default:
        //             day = "Not a valid date";
        //             break;
        // }

        //ternary operator
        //(condition)? <true value> : <False value>
        day = choice == 1 ? "Sunday" : choice == 2 ? "Monday" : choice == 3 ? "Tuesday" : choice == 4 ? "Wednesday" : choice == 5 ? "Thursday" : choice == 6? "Friday" : choice == 7? "Saturday" : "Not a valid entry.";
        Console.WriteLine(day);
    }
}
