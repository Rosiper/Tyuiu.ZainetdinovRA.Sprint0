using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainetdinovRA.Sprint0.Task6.V0.Lib;

namespace Tyuiu.ZainetdinovRA.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Sum of array elements = " + DataService.AdditionArray(numsArray));
            Console.WriteLine("Difference of array elements = " + DataService.SubtractionArray(numsArray));
            Console.WriteLine("Product of array elements = " + DataService.MultiplicationArray(numsArray));

            Console.ReadKey();
        }
    }
}
