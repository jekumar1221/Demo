using System;

namespace ConsoleApp1
{

     public class Students
    {
        public static void  TotalMarks( int[] list,ref int j, out int k)
        {
            int total = 0;
            for (int i = 0; i < list.Length; i++)
                total += list[i];
            k = total;
            j = 10;
             
        }

        public static string AllSubjects(params string[] subjects)
        {
            System.Text.StringBuilder builder = new System.Text.StringBuilder();
            for (int i = 0; i < subjects.Length; i++)
            {
                builder.Append(subjects[i]);
                builder.Append(" ");
            }
            return builder.ToString();
        }
    }

    //class Program
    //{

    //    static void Main(string[] args)
    //    {
    //        // Total for 3rd grade. Pass 3 comma separate values as params  
    //        Console.WriteLine("Params with 3 parameters");
    //        int total3 = Students.TotalMarks(8, 9, 8);
    //        // Print result  
    //        Console.WriteLine(total3);
    //        // Create an array of strings   
    //        string[] subs = { "English", "Reading", "Writing" };
    //        // Pass array of strings as a params and print result  
    //        Console.WriteLine(Students.AllSubjects(subs));

    //        // Total for 8th grade          
    //        Console.WriteLine("Params with 4 parameters");
    //        int[] marks = { 24, 22, 25, 21 };
    //        int total4 = Students.TotalMarks(marks);
    //        string str4 = Students.AllSubjects("Math", "English", "Art", "Social Science");
    //        Console.WriteLine(total4);
    //        Console.WriteLine(str4.ToString());

    //        // Total for 10th grade  
    //        Console.WriteLine("Params with 5 parameters");
    //        int total5 = Students.TotalMarks(92, 90, 95, 91, 98);
    //        string str5 = Students.AllSubjects(new string[] { "Math", "English", "Art", "Social Science", "Gym" });
    //        Console.WriteLine(total5);
    //        Console.WriteLine(str5.ToString());

    //        Console.ReadKey();
    //    }

    //}
}