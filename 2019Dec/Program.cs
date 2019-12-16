using System;

namespace _2019Dec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first number");

            int a = int.Parse( Console.ReadLine());
            Console.WriteLine("The number you entered is " + a);

            Console.WriteLine("Enter your second number");

            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The number you entered is " + b);

            Console.WriteLine("Sum of 2 numbers are " + add(a,b));
        }

        private static int add(int x, int y)
        {
            return x + y;
        }
    }
}
