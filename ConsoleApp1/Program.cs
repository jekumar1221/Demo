using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            StringOperation.generatePalindromes();
            List<string> emp = new List<string>();
            var res = emp.Select(e => e).FirstOrDefault();

            Console.WriteLine("Employee Name: {0}", res);

            StringOperation.RemoveDuplicate();
            Console.WriteLine("Hello World!");
            //OM
            int tmk = Convert.ToInt32("Jeet");
            string hjg = "Jeet";
           
            Students c = new Students();
            int[] ttt = { 1, 2, 3 };
             int jt = 7;
             int kt=8;
            Students.TotalMarks(ttt, ref jt, out kt);
            Console.WriteLine(kt.ToString()+jt.ToString());
           // int m = 2;
           // int n = 3;
            int[,] mat = { { 1, 2, 3 },
                        { 4, 5, 6 } };
            Console.WriteLine(mat.GetLength(0));
            Console.WriteLine(mat.GetLength(1));
            int maxLengthOfPath = 8;
            TraverseMatrix.Traverse(mat, 2, 3, 0, 0, new int[maxLengthOfPath], 0);
            

            Matrix();
            test();
            int n = 101;
            generatePalindromes(n);
            CountDistinctlement();
            FindActivePatterns();
            // two dimensional array
            int[,] intArry = new int[3, 4] { { 3,4,5,6} , { 3, 4, 5, 6 } , { 3, 4, 5, 6 } };
            for (int i = 0; i < intArry.GetLength(0); i++)
                for (int j = 0; j < intArry.GetLength(1); j++)
                    Console.WriteLine(intArry[i,j]);
            //three dimensional array
            int[,,] array3D = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },

                                                    { { 7, 8, 9 }, { 10, 11, 12 } } };
            for (int i = 0; i < array3D.GetLength(0); i++)
                for (int j = 0; j < array3D.GetLength(1); j++)
                    for (int k = 0; k < array3D.GetLength(2); k++)
                        Console.WriteLine(array3D[i, j,k]);

            //array of array Jagged array            
            int[][] intArry1 = new int[2][] { new int[] { 1,5,3,4}, new int[] { 2}  };             
            List<int> totalCount = new List<int>();
            for (int i = 0; i < intArry1.Length; i++)
                for (int j = 0; j < intArry1[i].Length; j++)
                {
                    totalCount.Add(intArry1[i][j]);
                    Console.WriteLine(intArry1[i][j]);
                }
            totalCount.Sort();
            foreach (int t in totalCount)
                Console.WriteLine(t);

            
            Console.ReadLine();
        }

        static void FindActivePatterns()
        {
            bool[] intArray = { false, true, false, true, false, true, false, true };
            bool[] temp = new bool[intArray.Length];
            int n = intArray.Length;
            for (int i = 0; i < intArray.Length; i++)
                temp[i] = intArray[i];

            intArray[0] = false ^ temp[0];
            intArray[n - 1] = false ^ temp[n - 1];

            for (int i = 1; i < n - 1; i++)
                intArray[i] = temp[i - 1] ^ temp[i + 1];


        }

        static void CountDistinctlement()
        {
            int[] t = { 15, 5, 2, 4, 6, 8, 4, 5, 2, 6, 2, 5, 6 };
            Dictionary<int, int> dictObject = new Dictionary<int, int>();
            for (int i = 0; i < t.Length; i++)
            {
                if (dictObject.ContainsKey(t[i]))
                    dictObject[t[i]]++;
                else
                    dictObject[t[i]]=1;

            }

            foreach (var pair in dictObject)
                //Console.WriteLine("{ 0} {1 }", pair.Key, pair.Value);
            Console.WriteLine("Value {0} occurred {1} times.", pair.Key, pair.Value);

        }

        static void generatePalindromes(int n)
        {

            int num, rem, sum = 0, temp;
            //clrscr();    
            Console.WriteLine("\n >>>> To Find a Number is Palindrome or not <<<< ");
            Console.Write("\n Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            while (num > 0)
            {
                rem = num % 10; //for getting remainder by dividing with 10    
                num = num / 10; //for getting quotient by dividing with 10    
                sum = sum * 10 + rem;
                /*multiplying the sum with 10 and adding  
                remainder*/
            }
            Console.WriteLine("\n The Reversed Number is: {0} \n", sum);
            if (temp == sum) //checking whether the reversed number is equal to entered number    
            {
                Console.WriteLine("\n Number is Palindrome \n\n");
            }
            else
            {
                Console.WriteLine("\n Number is not a palindrome \n\n");
            }
            Console.ReadLine();
            //int number;

            //// Run two times for odd and even  
            //// length palindromes 
            //for (int j = 0; j < 2; j++)
            //{

            //    // Creates palindrome numbers with first  
            //    // half as i. Value of j decided whether 
            //    // we need an odd length of even length 
            //    // palindrome. 
            //    int i = 1;
            //    while ((number = createPalindrome(i, 10,
            //                                j % 2)) < n)
            //    {
            //        Console.Write(number + " ");
            //        i++;
            //    }
            //}
        }

        static void test()
        {
            int[] array = { 1, 2, 3, 5, 6, 7, 8,9 };
            //int[] result = new int[array.Length];
            //for (int i = 0; i < array.Length; i++)
            //    result[i] = array[array.Length - 1 - i];
            //foreach (var i in result)
            //    Console.WriteLine(i);

            for (int i = 0; i < array.Length/2; i++)
            {
                int temp = array[i];
                //if ((i + 1) < array.Length)
                //{
                    array[i] = array[array.Length-1-i];
                    array[array.Length -1-i] = temp;
                //}
            }

            foreach (var i in array)
                Console.WriteLine(i);


        }

        static void Matrix()
        {
            int[,] matrix = { { 1, 2, 3 }, { 2, 5, 6 }, { 7, 8, 9 } };
            //Console.WriteLine(matrix.Length + " " +matrix.GetLength(0) +" " +matrix.GetLength(1));
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int temp;
                    if ((j + 1) < matrix.GetLength(1))
                    {
                       // temp = matrix[i, j + 1];
                        matrix[i, j + 1]= matrix[i, j];
                       // temp = matrix[i, j + 1];
                    }
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
        }

        static int[,] rotate(int[,] tempMatrix, int temp, int i, int j)
        {
            return tempMatrix;
        }
    }
     
    
}
