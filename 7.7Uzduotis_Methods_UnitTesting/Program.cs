using System;

namespace _7._7Uzduotis_Methods_UnitTesting
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("iveskite ilgi ir ploti: ");
            double length = Convert.ToDouble(Console.ReadLine());
            double width = Convert.ToDouble(Console.ReadLine());
            double result = CalculateRectangleArea(length, width);
            Console.WriteLine(result);
        }
        public static double CalculateRectangleArea(double plot, double ilg)
        {
            return plot * ilg;
        }


    }
}