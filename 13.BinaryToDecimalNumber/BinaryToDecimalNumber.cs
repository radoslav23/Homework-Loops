/*Using loops write a program that converts a binary integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:

binary	                            decimal
0	                                0
11	                                3
1010101010101011	                43691
1110000110000101100101000000	    236476736*/
using System;

class BinaryToDecimalNumber
{
    static void Main()
    {
        double sum = 0;
        long n = long.Parse(Console.ReadLine());
        long str = n.ToString().Length;
        for (int i = 0; i < str; i++)
        {
            long lastDigit = n % 10;
            sum = sum + lastDigit*Math.Pow(2, i);
            n = n/10;
        }
        Console.WriteLine(sum);

        /*Another solution
        var s = "101011";    // my binary "number" as a string
        var dec = 0;
        for (int i = 0; i < s.Length; i++)
        {
            // we start with the least significant digit, and work our way to the left
            if (s[s.Length - i - 1] == '0') continue;
            dec += (int)Math.Pow(2, i);
        }*/
    }
}

