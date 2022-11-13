using System;

namespace NumberInRange
{
    class NumbesInRange
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            if (-100 <= number && number <= 100 && number != 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

