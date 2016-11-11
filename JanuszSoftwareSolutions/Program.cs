using System;

namespace JanuszSoftwareSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1000;
            int i = 0;
            double a = 3;
            double b = 4;
            while (i < count)
            {

                Swap(ref a, ref b);
                i++;
            }
            Console.WriteLine(a);
            Console.ReadLine();


        }

        private static void Swap(ref double a, ref double b)
        {
            double result = CalculateValue(a, b);
            double border = CalculateBorder(a, b);
            if (IsGreater(result))
            {
                a = border;
            }
            else
            {
                b = border;
            }

        }

        private static double CalculateValue(double a, double b)
        {
            return (Math.Sin(a) + Math.Sin(b))/2;
        }

        private static double CalculateBorder(double a, double b)
        {
            return (a + b)/2;
        }

        private static bool IsGreater(double result)
        {
            return result > 0;
        }
    }
}

