using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProject
{
    public static class Lesson1
    {
        public static void PrimitiveTypesDemo()
        {
            // Primitive data types
            int x = 4;
            double y = 5.2;
            float z = 1.0f;
            bool b = true;
            string s = "any string";
            char c = 'a';

            // Writing to standard output:
            Console.WriteLine("Any string name");
            Console.WriteLine(x);
            Console.WriteLine("y = " + y);
            Console.WriteLine($"z = {z}");

            // Reading from the standard input:
            Console.Write("Enter a value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("a = " + a);

            Console.Write("Enter your name: ");
            string ss = Console.ReadLine();
            Console.WriteLine("Hello " + ss);

            Console.Write("Enter the float value: ");
            float f = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("f = " + f);


            int age;
            // You can't use a varialbe before assigning a value to it
            age = x + 1;
            Console.WriteLine("Age = " + age);


            // Converion between types:
            z = (float)y;
            int MyVariable = (int)y;
            Console.WriteLine($"y = {y}, MyVariable = {MyVariable}");


            //using var keyword
            var test = 10;
        }

        public static int AddTwoNumbers(int x, int y)
        {
            return x + y;
        }

        public static void ForLoopExample()
        {
            Console.WriteLine("For loop example");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I = " + i);
            }
        }

        public static void WhileLoopExample()
        {
            Console.WriteLine("While loop example");

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("I = " + i);
                i++;
            }
        }

        public static void IfStatementExample1()
        {
            Console.Write("Enter x value: ");
            var x = Convert.ToInt32(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("x is equal 0");
            }
            else
            {
                Console.WriteLine("X is not equal to 0");
            }
        }

        public static void IfStatementExample2()
        {
            Console.Write("Enter y value: ");
            var y = Convert.ToInt32(Console.ReadLine());

            if (y != 0)
            {
                Console.WriteLine("y is not equal 0");
            }
            else
            {
                Console.WriteLine("y is equal to 0");
            }
        }

        public static void IfStatementAndOperatorExample()
        {
            int x = 10;

            if (x > 0 && x < 20)
            {
                Console.WriteLine($"X = {x}, is greater than 0 and less that 20");
            }
        }

        public static void IfStatementOrOperatorExample()
        {
            int x = 300;

            if (x == 100 || x == 200)
            {
                Console.WriteLine($"X = {x}");
            }
            else
            {
                Console.WriteLine("X is neither 100 nor 200");
            }
        }
    }
}
