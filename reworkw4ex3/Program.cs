using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reworkw4ex3
{
    internal class Program
    {
        static void Main(string[] args)
        { // init a 2x3 matrix
          int[,] matrix = new int[,] { 
           { 1, 2, 3 }, { 4, 5, 6 } 
            };
            // loop through rows
            for (int i =0; i <matrix.GetLength(0); i++)
            { // Loop through columns

              for (int j= 0; j < matrix.GetLength(1); j++) 
                { // display matrix by tabular
                    Console.Write(matrix[i, j] + "\t"); 
                } // enter newline
                Console.WriteLine();
            }
            // init sum to 0
         int sum  = 0;
            // go through each element
            foreach (int i in matrix)
            {


                sum += i; // add sum to i
            }
            // display sum
            Console.WriteLine("the sum is " + sum);

            


             // get the number of rows in the original matrix
             int rows = matrix.GetLength(0);
             // get the number of columns in the original matrix
             int cols =  matrix.GetLength(1);
             // Create a transposed matrix (2x3)
             int[,]  transposed =new int[cols, rows];


            // loop through matrix rows
           for (int i = 0; i < rows; i++)
            {   //loop through matrix columns
              for (int j = 0; j < cols; j++)
                  { // Swap row and column
                   transposed[j, i] = matrix[i, j]; 
                 }
            }
            // Loop through rows
            for (int i=0; i < transposed.GetLength(0); i++)
            {     // Loop through columns
                for (int j =0; j < transposed.GetLength(1); j++) 
                { // display transposed by tabular
                  Console.Write(transposed[i, j] + "\t");
                } // enter a newline
              Console.WriteLine(); } 
            // wait for input before closing 
            Console.Read();
        }
    }
 }

