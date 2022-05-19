// See https://aka.ms/new-console-template for more information
using System;
using System.Text;

namespace LoopingStatements
{
    public class Program 
    {
        public static void Main()
        {
            LoopingStatements();
            StringManipulation();
        }

        private static void LoopingStatements()
        {
            //Break and Continue  
            for (int i=0; i<10;i++)
            {
                if(i==4){
                    break;
                }
                Console.WriteLine(i);
            }


            for (int i=0; i<10;i++)
            {
                if(i==4){
                    continue;
                }
                Console.WriteLine(i);
            }
            //while loop are used for unknown quantities
            //doing tasks repeayedly
            //initialization, condition, inc/decrement

            // var res = "";
            // do{
            //     Console.WriteLine("Do you want to continue?");
            //     res = Console.ReadLine();
            // }while(res.ToUpper()=="Y");



            //Known quantities

            //usig while loop to print table of 10
            // Console.WriteLine("Enter the number");
            // var num = Convert.ToInt32(Console.ReadLine());
            // int i = 1;
            // while(i<=10)
            // {
            //     Console.WriteLine(num + "x" + i + "=" + (num)*i);
            //     i++;
            // }

            // for(i=1;i<=10;i++)
            // {
            //     Console.WriteLine(num + "x" + i + "=" + (num)*i);
            // }

            

            // string[] days = new string[] {"Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"};

            // foreach (var item in days)
            // {
            //     Console.WriteLine("Days = " + item);
            // }

            // for(i=0; i<days.Length; i++)
            // {
            //     Console.WriteLine("Days = " + days[i]);
            // }

            

                      
        }
        private static void StringManipulation()

        {
            // string s1 = "Hello";
            // string s2 = "Ncc";

            // //string concatination
            // Console.WriteLine(s1 + " " + s2);

            // //string formatting
            // string templ = "{0} {1}";
            // var res1 = string.Format(templ, s1, s2);
            // Console.WriteLine("{0} {1}", s1, s2);

            // //string interpolation
            // var res2 = $"{s1}! {s2}";
            // Console.WriteLine(res2);

            //Access Strings
            // string myString = "Hello";
            // Console.WriteLine(myString[0]);

            // Console.WriteLine(myString.IndexOf("e"));

            // string name = "Ranjeet Mahato";
            // //Location of the letter M
            // int charPos = name.IndexOf("M");

            // //Get last name
            // string lastName = name.Substring(charPos);
            // Console.WriteLine(lastName);

            //stringBuilder
            // StringBuilder sb = new StringBuilder();
            // sb.AppendLine("Lohdsdfufu");
            // var res3 = sb.ToString();
            // Console.WriteLine(res3);

            //Because strings mjst be written within quotes
            // string txt = "We\'re .net\\C# developers.";
            // Console.WriteLine(txt);

        }
    }
}
