/*
 * Student Arrays
 * 1/25/2023
 * C#.NET I
 * 
 * Instructions:
 * Run the program and observe the output. Modify the
 * program so that it displays Jen's name and score
 * on a line in the console.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Jimbo", "Jim", "Jenbo", "Jen" };
            double[] testScores = { 100.0, 75.5, 95.75, 97.25 };
            Console.WriteLine(students[0] + ":\t" + testScores[0]);
            Console.WriteLine(students[1] + ":\t" + testScores[1]);
            Console.WriteLine(students[2] + ":\t" + testScores[2]);
        }
    }
}
