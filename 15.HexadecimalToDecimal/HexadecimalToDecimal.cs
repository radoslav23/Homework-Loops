/*Using loops write a program that converts a hexadecimal integer number to its decimal form.
The input is entered as string. The output should be a variable of type long.
Do not use the built-in .NET functionality.
Examples:

hexadecimal	    decimal
FE	            254
1AE3	        6883
4ED528CBB4	    338583669684*/
using System;

class HexadecimalToDecimal
{
    static void Main()
    {
        string hex = Console.ReadLine();
        int count = hex.Length - 1;
        long decimalNumber = 0;
        long temp = 0;

        for (int i = 0; i < hex.Length; i++)
        {
            switch (hex[i])
            {
                case 'A':
                    temp = 10; break;
                case 'B':
                    temp = 11; break;
                case 'C':
                    temp = 12; break;
                case 'D': 
                    temp = 13; break;
                case 'E':
                    temp = 14; break;
                case 'F':
                    temp = 15; break;
                default:
                    temp = int.Parse(hex[i].ToString()); break;
            }
            decimalNumber = decimalNumber +  temp*(long) Math.Pow(16, count - i);
        }
        Console.WriteLine(decimalNumber);
    }
}

