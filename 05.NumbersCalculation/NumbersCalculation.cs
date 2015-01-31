/*Write a program that, for a given two integer numbers n and x, 
calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
Use only one loop. Print the result with 5 digits after the decimal point.*/
using System;

class NumbersCalculation
{
    static void Main()
    {
        double sum = 0.00;
        double factorial = 1.00;
        double power = 1.00;

        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            power *= x;
            sum += factorial / power;
        }
        Console.WriteLine("The sum is {0:0.00000}", 1 + sum);
    }
}
