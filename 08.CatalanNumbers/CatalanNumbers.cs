/*Write a program to calculate the nth Catalan number 
by given n (1 <= n <= 100).*/
using System;

class CatalanNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        while (n < 0)
        {
            Console.WriteLine("Enter 0 or positive number: ");
            n = double.Parse(Console.ReadLine());
        }

        double factorialN = 1;
        //Here is calculated member factorial
        for (double i = n; i > 0; i--)
        {
            factorialN *= i;
        }

        double fact2MultiplcMember = 1;
        double firstCalculation = 2*n;
        //Here is calculated (2*n)!
        for (double i = firstCalculation; i > 0; i--)
        {
            fact2MultiplcMember *= i;
        }

        double factMemberPlus1 = 1;
        double secondCalculation = n + 1;
        //Here is calculated (n+1)!
        for (double i = secondCalculation; i > 0; i--)
        {
            factMemberPlus1 *= i;
        }

        //Here is calculated ((n+1)! * n!)
        double thirdCalculation = factMemberPlus1*factorialN;
        //Here is final calculation
        double result = fact2MultiplcMember/thirdCalculation;
        Console.WriteLine(result);
    }
}

