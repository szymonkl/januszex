using System;

namespace JanuszSoftwareSolutions
{
    class Bisection
    {
        public static double CalculatePi(double leftBorder, double rightBorder, double stepsCount)
        {
            int i = 1;
            while (i < stepsCount)
            {
                Swap(ref leftBorder, ref rightBorder);
                i++;
            }

            return CalculateBorder(leftBorder, rightBorder);

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
            return (Math.Sin(a) + Math.Sin(b)) / 2;
        }

        private static double CalculateBorder(double a, double b)
        {
            return (a + b) / 2;
        }

        private static bool IsGreater(double result)
        {
            return result > 0;
        }


        public static double CalculatePi_SpecifiedPrecision(double leftBorder, double rightBorder, double precision)
        {
            double result = 5;
            while (IsEqual(result, precision))
            {
                result = CalculateValue(leftBorder, rightBorder);
                var border = CalculateBorder(leftBorder, rightBorder);
                if (IsGreater(result))
                {
                    leftBorder = border;
                }
                else
                {
                    rightBorder = border;
                }

            }

            return CalculateBorder(leftBorder, rightBorder);


        }

        private static bool IsEqual(double result, double precision)
        {
            return Math.Abs(result) > precision;
        }
    }
}