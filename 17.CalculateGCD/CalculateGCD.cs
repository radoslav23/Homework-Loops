/*Write a program that calculates the greatest common divisor 
(GCD) of given two integers a and b.
Use the Euclidean algorithm (find it in Internet).
Examples:

a	    b	    GCD(a, b)
3	    2	    1
60	    40	    20
5	    -15	    5*/
using System;
using System.Data.SqlTypes;

class CalculateGCD
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double reminder = 1;

        if (a > b)
        {
            if (a % b == 0)
            {
                reminder = b;
            }
            else
            {
                reminder = a%b;
                if (reminder != 0)
                {
                    reminder %= b;
                }
            }
        }
        else if (a == b || a < b)
        {
            if (b % a == 0)
            {
                reminder = a;
            }
            else
            {
                reminder = b%a;
                if (reminder != 0)
                {
                    reminder %= a;
                }
            }
        }
        Console.WriteLine("The greatest common divisor of {0} and {1} is {2}.", a, b, reminder);
    }
}

