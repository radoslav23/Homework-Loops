/*Using loops write a program that converts an integer number to its binary representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:

decimal	        binary
0	            0
3	            11
43691	        1010101010101011
236476736	    1110000110000101100101000000*/
using System;

class DecimalToBinary
{
    static void Main()
    {
        long reminder = 0;
        long n = long.Parse(Console.ReadLine());
        string result = String.Empty;
        while (n > 0)
        {
            reminder = n % 2;
            n /= 2;
            result = reminder.ToString() + result;
        }
        Console.WriteLine(result);

    }
}

