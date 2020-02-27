using System;

namespace SimpleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SimpleCalculation();

            Console.Write("Zahl 1: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calculator.Add(num1, num2));
        }
    }
}
