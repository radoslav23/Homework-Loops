/*In combinatorics, the number of ways to choose k different members 
out of a group of n different elements (also known as the number of combinations) 
is calculated by the following formula: formula For example, there are 2598960 ways 
to withdraw 5 cards out of a standard deck of 52 cards.
Your task is to write a program that calculates 
n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). 
Try to use only two loops.*/
using System;

class FactorialsCalculation
{
    static void Main()
    {
        double factorialN = 1;
        double n = double.Parse(Console.ReadLine());
        double saveN = n;
        while (n < 3 || n > 99)
        {
            Console.Write("Enter number in range [3-99]: ");
            n = double.Parse(Console.ReadLine());
        }

        double factorialK = 1;
        double k = double.Parse(Console.ReadLine());
        double saveK = k;
        while (k <= 1 || k >= n)
        {
            Console.Write("Enter number in range [2-{0}]: ", n);
            k = double.Parse(Console.ReadLine());
        }

        for (double i = n; i > 0; i--)
        {
            factorialN *= i;
        }
        // Here is calculated factorialN
        //Console.WriteLine(factorialN);

        for (double i = k; i > 0; i--)
        {
            factorialK *= i;
        }
        // Here is calculated factorialK
        //Console.WriteLine(factorialK);

        double nSubtractionK = n - k;
        //Here is calculated (n-k)
        //Console.WriteLine(nSubtractionK);
        double nSubtractionKFactrorial = 1;
        for (double i = nSubtractionK; i > 0; i--)
        {
            nSubtractionKFactrorial *= i;
        }
        //Here is calculated (n-k)!
        //Console.WriteLine(nSubtractionKFactrorial);

        double kFactMultiplcNMinusKFact
            = factorialK * nSubtractionKFactrorial;
        //Here is calculated (k! * (n-k)!)
        //Console.WriteLine(kFactMultiplcNMinusKFact);
        double nFactorialDividekFactMultiplcNMinusKFact
            = factorialN / kFactMultiplcNMinusKFact;
        //Here is calculated n! / (k! * (n-k)!)
        Console.WriteLine(nFactorialDividekFactMultiplcNMinusKFact);       
    }
}
