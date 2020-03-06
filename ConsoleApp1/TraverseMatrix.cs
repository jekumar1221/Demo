using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TraverseMatrix
    {
       public  static void Traverse(int[,] matrix,int m,int n,int i,int j,int[] path, int temp)
        {
            // int ttt = countPaths(3, 3);
            justTest();
             path[temp] = matrix[i, j];
            if (i == m - 1)
            {
                for (int k = j + 1; k < n; k++)
                {
                    path[temp + k - j] = matrix[i, k];
                }
                for (int l = 0; l < 4; l++)
                {
                    Console.Write(path[l]);
                }
                Console.WriteLine();
                return;
            }

            if (j == n - 1)
            {
                for (int k = i + 1; k < m; k++)
                {
                    path[temp + k - i] = matrix[k,j];
                }
                for (int l = 0; l < 4; l++)
                {
                    Console.Write(path[l]);
                }
                Console.WriteLine();
                return;
            }
            Traverse(matrix,m,n,i+1,j,path,temp+1);
            Traverse(matrix, m, n, i, j+1, path, temp + 1);
        }

        //Count the number of ways to traverse a Matrix
        // Returns The number of way  
        // from top-left to mat[m-1][n-1] 
        public static int countPaths(int m, int n)
        {
            // Return 1 if it is the first 
            // row or first column 
            if (m == 1 || n == 1)
                return 1;

            // Recursively find the no of  
            // way to reach the last cell. 
            return countPaths(m - 1, n) +
                countPaths(m, n - 1);
        }

        public static void justTest()
        {
            int[] t = { 1, 2, 3, 4, 5, 6 };

            Array.Reverse(t);
            //int temp = 0;
            //for (int i = 0; i < t.Length / 2; i++)
            //{
            //    temp = t[i];
            //    t[i] = t[t.Length - 1 - i];
            //    t[t.Length - 1 - i] = temp;

            //}
            for (int i = 0; i < t.Length; i++)
            {
                Console.WriteLine(t[i]);
            }
        }
    }
}
