using System;
namespace SimpleTest
{
    public class SimpleCalculation
    {
        public SimpleCalculation()
        {
         
        }

        public int Add(int sum1, int sum2)
        {
            return sum1 + sum2;
        }

        public int Power(int baseNumber, int exponent)
        {
            int result = baseNumber;

            for (int i = 0; i < exponent; i++)
            {
                result *= baseNumber;
            }

            return result;
        }
    }
}
