/*
 * Initialize Array
 * 1/25/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. Be prepared
 * to discuss the following questions...
 * 1. How many elements does array, names, dollarAmounts,
 *    and isAttendingArray store?
 * 2. Based on these examples, how should we name arrays?
 * 3. What happens when you print an array using Console.WriteLine()
 *    or Console.Write()?
 * 4. What values are used by default when initializing an array?
 * 
 * Finally, modify the program by creating a new array that
 * can store 1000 integers. Name you array numbers.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Part 1
            int[] array;
            array = new int[6];
            Console.WriteLine(array);
            PrintArray(array);
            Console.WriteLine();

            // Part 2
            string[] names = new string[10];
            double[] dollarAmounts = new double[10];
            bool[] isAttendingArray = new bool[100];
            PrintArray(names);
            PrintArray(dollarAmounts);
            PrintArray(isAttendingArray);
        }

        /*
         * These print the contents of the array such that
         * each element is seperated by a comma. Don't worry
         * if you don't understand them yet, we will discuss
         * the code tomorrow.
         */
        public static void PrintArray(int[] a)
        {
            for(int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.WriteLine(a[a.Length - 1]);
        }

        public static void PrintArray(double[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.WriteLine(a[a.Length - 1]);
        }

        public static void PrintArray(string[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.WriteLine(a[a.Length - 1]);
        }

        public static void PrintArray(bool[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.WriteLine(a[a.Length - 1]);
        }
    }
}
