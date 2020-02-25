using System;

namespace SimpleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new SimpleCalculation();

            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calculator.Add(num1, num2));
        }
    }
}
