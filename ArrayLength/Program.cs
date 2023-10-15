/*
 * Array Access
 * Pawelski
 * 10/15/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Run the program and observe the output. Be prepared
 * to discuss the following questions...
 * 1. What index should you use to access the first element
 *    in an array when you don't know the length of the array?
 * 2. What index should you use to access the last element
 *    in an array when you don't know the length of the array?
 * 3. When an expression is inside the square brackets [], how
 *    is the statement executed?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayLength
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] companies = { "Dell", "Lenovo", "Alienware", "HP" };
            Console.WriteLine(companies.Length);
            Console.WriteLine(companies[0]);
            Console.WriteLine(companies[companies.Length - 1]);
        }
    }
}
