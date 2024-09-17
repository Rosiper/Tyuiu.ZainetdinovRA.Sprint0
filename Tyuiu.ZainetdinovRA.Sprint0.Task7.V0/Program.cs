using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ZainetdinovRA.Sprint0.Task7.V0.Lib;


namespace Tyuiu.ZainetdinovRA.Sprint0.Task7.V0
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.Title = "Спринт #0 | Выполнил: Zainetdinov R. A. | ИИПБ-24-2";
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* Спринт #0                                                           *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                         *");
            Console.WriteLine("* Задание #7                                                          *");
            Console.WriteLine("* Вариант #0                                                          *");
            Console.WriteLine("* Выполнил: Зайнетдинов Руслан Александрович | ИИПБ-24-2              *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                            *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения     *");
            Console.WriteLine("* двух одинаковых массивов по длине                                   *");
            Console.WriteLine("*                                                                     *");
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                    *");
            Console.WriteLine("***********************************************************************");

            int[] arrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Values of the first array elements");
            for (int i = 0; i < arrayNums1.Length; i++)
            {
                Console.Write(arrayNums1[i] + ", ");
            }


            int[] arrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Values of the second array elements");
            for (int i = 0;i < arrayNums2.Length; i++)
            {
                Console.Write(arrayNums2[i] + ", ");
            }

            Console.WriteLine();
            Console.WriteLine("***********************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                          *");
            Console.WriteLine("***********************************************************************");

            if (arrayNums1.Length == arrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);

                Console.WriteLine("Sum of array elements is equal to:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Error! The initial arrays have different numbers of elements");
            }

            Console.ReadKey();
        }
    }
}
