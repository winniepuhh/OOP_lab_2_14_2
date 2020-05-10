using System;

namespace OOP_lab_2_14_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = -6;

            while (x <= 3)
            {
                double y = x * x * x;

                Console.WriteLine("x = {0, 5:f2}, y = {1, 9:f4}", x, y);

                x += 0.75;
            }
        }
    }
}
