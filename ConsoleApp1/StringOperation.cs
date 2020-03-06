using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class StringOperation
    {

        public static void RevreseString()
        {
            string myString = "jeetender Kumar";
            StringBuilder result = new StringBuilder();
            for (int i = myString.Length-1; i >=0; i--)
            {
                result.Append(myString[i]);
            }

            Console.WriteLine(result.ToString());
        }

        public static void RemoveDuplicate()
        {
            string mystring = "jeetender";
             
            char[] str = mystring.ToCharArray();
           if (str == null) return; 
           int len = str.Length;
           if (len < 2) return;
           int tail = 1;
            for (int i = 1; i < len; i++)
            {
                 int j;
                for (j = 0; j < tail; j++)
                { if (str[i] == str[j])
                        break;
                }
                if (j == tail)
                {
                    str[tail] = str[i];
                    Console.WriteLine(string.Join(' ', str));
                    ++tail;
                }
                Console.WriteLine(string.Join(' ', str));
            }

            for(int h= tail;h< str.Length;h++)
              str[h] = ' ';

            Console.WriteLine(string.Join(' ',str));
        }

        public static void Remdup()
        {
            string t = "Jeetender";
            char[] str = t.ToCharArray();
            int index = 0;

            // Traverse through all characters 
            for (int i = 0; i < str.Length; i++)
            {

                // Check if str[i] is present before it  
                int j;
                for (j = 0; j < i; j++)
                {
                    if (str[i] == str[j])
                    {
                        break;
                    }
                }

                // If not present, then add it to 
                // result. 
                if (j == i)
                {
                    str[index++] = str[i];
                }
            }
            char[] ans = new char[index];
            Array.Copy(str, ans, index);
             
            Console.WriteLine( String.Join("", ans));
        }
        public static void DublicateCount()
        {
            string str = "Jeetender";
            Dictionary<string, int> dt = new Dictionary<string, int>();

            for (int i = 0; i < str.Length; i++)
            {
                if (dt.ContainsKey(str[i].ToString()))
                {
                    dt[str[i].ToString()]++;
                }
                else
                {

                    dt.Add(str[i].ToString(), 1);
                }
            }
            string j;
        }

        public static void generatePalindromes()
        {
            string str = "ABCDEDCBA";
            string first = str.Substring(0, str.Length / 2);
            char[] st = str.ToCharArray();
            Array.Reverse(st);
            string t = new string(st);
            string second = t.Substring(0, t.Length / 2);
            if (first == second)
                Console.Write("Palindromes");
        }


    }
}
