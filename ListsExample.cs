using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    static public class ListsExample
    {
        static public void Example1()
        {
            var numbers = new List<int>();

            PrintList(numbers);

            // Adding elements
            numbers.Add( 1 );
            numbers.Add( 1 );
            numbers.Add( 2 );
            numbers.Add( 3 );

            PrintList(numbers);

            // Removing all elements:
            numbers.Clear();

            PrintList(numbers);
        }

        static void PrintList(List<int> values)
        {
            Console.WriteLine($"The size the list is: {values.Count}");

            foreach(var value in values)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine("**********************************");
        }
    }
}
