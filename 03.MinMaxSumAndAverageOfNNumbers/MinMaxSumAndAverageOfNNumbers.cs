/*Write a program that reads from the console a sequence of n integer numbers 
and returns the minimal, the maximal number, the sum and the average of all numbers 
(displayed with 2 digits after the decimal point).
The input starts by the number n (alone in a line) followed by n lines, 
each holding an integer number.
The output is like in the examples below.*/
using System;

class MinMaxSumAndAverageOfNNumbers
{
    static void Main()
    {

        double min = double.MaxValue;
        double max = double.MinValue;
        Console.Write("Enter num in interval: ");
        double n = double.Parse(Console.ReadLine());
        double sum = 0;
        double average = 0;
        for (double i = 0; i < n; i++)
        {
            Console.Write("Enter the number: ");
            double num = double.Parse(Console.ReadLine());

            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
            sum += num;
            average = sum/n;
        }
        Console.Write("min = {0}\nmax = {1}\n", min, max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("average = {0:0.00}", average);
    }
}

