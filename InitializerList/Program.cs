﻿/*
 * Initializer List
 * Pawelski
 * 10/15/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Try running the program. Be prepared
 * to discuss the following questions...
 * 1. There is something wrong with line 31! What is wrong with
 *    the line and how would you fix it? Then run the program and
 *    observe the output.
 * 2. How many elements does the array ph store?
 * 
 * Finally, modify the program by creating a new array that stores
 * the numbers 2, 5, 1, 7, 9, and 3. Name you array numbers. Print
 * the array so that you can see the numbers get stored.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InitializerList
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5] { "Jim", "Joe", "John", "Jen" };
            double[] ph = { 7.0, 3.2, 4.5, 2.1, 5.9, 12.0 };

            PrintArray(ph);
            PrintArray(names);
        }

        public static void PrintArray<T>(T[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                Console.Write(a[i] + ", ");
            }
            Console.WriteLine(a[a.Length - 1]);
        }
    }
}
