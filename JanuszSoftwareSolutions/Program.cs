using System;

namespace JanuszSoftwareSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine(Bisection.CalculatePi(3,4,100));
            Console.WriteLine(Bisection.CalculatePi_SpecifiedPrecision(3,4,0.000000000000001));

            Console.ReadLine();


        }
    }
}

