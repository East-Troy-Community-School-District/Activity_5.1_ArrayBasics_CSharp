/*
 * First Last Letter
 * Pawelski
 * 10/15/2023
 * Developing Desktop Applications
 * 
 * Instructions:
 * Run the program and observe the output. Be prepared
 * to discuss the following questions...
 * 1. What index should you use to access the first character
 *    in a string when you don't know the length of the array?
 * 2. What index should you use to access the last character
 *    in a string when you don't know the length of the array?
 * 3. When an expression is inside the square brackets [], how
 *    is the statement executed?
 * 4. Try adding this line of code to the program...
 *    word[0] = "q";
 *    
 *    When you try running the program, it does not work! Why?
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLastLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            Console.Write("Enter a word >> ");
            word = Console.ReadLine();
            Console.WriteLine("First letter: " + word[0]);
            Console.WriteLine("Last letter: " + word[word.Length - 1]);
        }
    }
}
