using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DemoProject
{
    public static class ArraysExample
    {
        public static void Example1()
        {
            int[] numbers = { 1, 2 };

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine("--------------");
        }

        public static void ArrayWithForLoop()
        {
            var numbers = new float[2];

            numbers[0] = 10.2f;
            numbers[1] = 20.3f;

            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + 10);
            }
        }

        public static void ArrayWith_foreach_loop()
        {
            Console.WriteLine("array with foreach example");
            var numbers = new float[2];

            numbers[0] = 10.2f;
            numbers[1] = 20.3f;

            foreach(float value in numbers)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("-------------");

            foreach (var value in numbers)
            {
                Console.WriteLine(value);
            }
        }

        public static void TwoDimentionalArray()
        {
            Console.WriteLine("Learning what hard-coded values concept is");
            Console.WriteLine("Here, we're using nameof(numbers) for not hard-coding the name of the array");
            int[,] numbers =
            {
                { 1, 2, 3 },
                {2, 5, 6 },
            };

            Console.WriteLine($"Number of elements in {nameof(numbers)} is {numbers.Length}");
            Console.WriteLine($"This array has {numbers.Rank} dimentions");
        }

        public static void TwoDimentionalArrayExample2()
        {
            var values = new int[3, 2];

            int numberOfRows = values.GetLength(0);
            int numberOfColumns = values.GetLength(1);

            Console.WriteLine($"Number of raws is: {numberOfRows}");
            Console.WriteLine($"Number of columns is: {numberOfColumns}");

            int number = 1;

            // Writing values to the array
            for(int i = 0; i <  numberOfRows; i++)
            {
                for(int j = 0; j < numberOfColumns; j++)
                {
                    values[i, j] = number++;
                }
            }

            Console.WriteLine("Reading values from the array:");
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Console.WriteLine(values[i, j]);
                }
            }
        }
    }
}
