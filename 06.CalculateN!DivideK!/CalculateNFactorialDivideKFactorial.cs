/*Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
Use only one loop.*/
using System;
using System.Globalization;

class CalculateNFactorialDivideKFactorial
{
    static void Main()
    {
        double factorialN = 1;
        double factorialK = 1;

        double n = double.Parse(Console.ReadLine());
        double k = double.Parse(Console.ReadLine());

        for (double i = n; i > 0; i--)
        {
            factorialN *= i;                
        }

        for (double j = k; j > 0; j--)
        {
            factorialK *= j;
        }       
        Console.WriteLine(factorialN / factorialK);
    }
}

