/*Write a program that calculates with how many zeroes 
the factorial of a given number n has at its end.
Your program should work well for very big numbers, e.g. n=100000.
Examples:

n	    trailing zeroes of n!	explaination
10	    2	                    3628800
20	    4	                    2432902008176640000
100000	24999	                think why*/
using System;
using System.Numerics;

class TrailingZerosInN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int saveN = n;
        BigInteger factorial = 1;
        for (int i = n; i > 0; i--)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
        int factorialTrailingZeros = 0;

        while (n > 0)
        {
            n /= 5;
            factorialTrailingZeros += n;
        }
        Console.WriteLine("{0} have {1} trailing zeros in his factorial."
            , saveN, factorialTrailingZeros);
    }
}

