/*
 * Array Access
 * 1/25/2023
 * C#.NET I
 * 
 * Instructions:
 * Try running the program. Be prepared
 * to discuss the following questions...
 * 1. There is something wrong with line 35! What is wrong with
 *    the line? Fix the line so that it stores 24 in the last
 *    element of the array. Check your work by running the program
 *    and observing the output.

 * Finally, modify the program store it stores 67.628 in the 3rd
 * element. Print the stored value to the console to confirm it
 * was stored in the array. In addition, modify the code so that
 * averageVolumes factors this new volume into the average.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] volumes = new double[3];
            volumes[0] = 16.9;
            volumes[1] = 12;
            volumes[3] = 24;

            Console.WriteLine(volumes[0]);
            Console.WriteLine(volumes[1]);
            Console.WriteLine(volumes[9]);

            double averageVolume = (volumes[0] + volumes[1] + volumes[9]) / 3;
            Console.WriteLine(averageVolume);
        }
    }
}
