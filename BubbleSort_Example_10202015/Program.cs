//Joshua Pickenpaugh, IN2017
//October 20th, 2015
//Bubble sort.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort_Example_10202015
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 34, 123, 12, 76, 29, 54, 87 };
            Console.WriteLine("Before the bubble sort:");
            DisplayArrayValues(numbers);
            Console.WriteLine();

            Console.WriteLine("After the bubble sort:");
            BubbleSortArrayValues(numbers);
            DisplayArrayValues(numbers);
            Console.WriteLine();

            Console.WriteLine("Hit a key to escape program.");

            Console.ReadKey();
        }

        static void DisplayArrayValues(int[] arrayValues)
        {
            for (int i = 0; i < arrayValues.Length; i++)
            {
                Console.WriteLine("{0}", arrayValues[i]);
            }
            Console.WriteLine();
        }

        static int[] BubbleSortArrayValues(int[] arrayValues)
        {
            bool arrayValuesSwapped;
            do
            {
                arrayValuesSwapped = false;
                for (int i = 0; i < arrayValues.Length - 1; i++)
                {
                    if (arrayValues[i] > arrayValues[i + 1])
                    {
                        int x = arrayValues[i + 1];
                        arrayValues[i + 1] = arrayValues[i];
                        arrayValues[i] = x;
                        arrayValuesSwapped = true;
                    }
                }
            } while (arrayValuesSwapped == true);

            return arrayValues;
        }
    }
}
