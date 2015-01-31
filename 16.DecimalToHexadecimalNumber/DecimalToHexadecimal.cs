/*Using loops write a program that converts an integer number to its hexadecimal representation.
The input is entered as long. The output should be a variable of type string.
Do not use the built-in .NET functionality.
Examples:

decimal	        hexadecimal
254	            FE
6883	        1AE3
338583669684	4ED528CBB4*/
using System;

class DecimalToHexadecimal
{
    static void Main()
    {
        long decimalNumber = long.Parse(Console.ReadLine());
        string hex = string.Empty;
        if (decimalNumber != 0)
        {
            while (decimalNumber > 0)
            {
                long reminder = decimalNumber%16;
                switch (reminder)
                {
                    case 10:
                        hex += 'A'; break;
                    case 11:
                        hex += 'B'; break;
                    case 12:
                        hex += 'C'; break;
                    case 13:
                        hex += 'D'; break;
                    case 14:
                        hex += 'E'; break;
                    case 15:
                        hex += 'F'; break;
                    default:
                        hex = reminder.ToString(); break;
                }
                decimalNumber /= 16;
            }
            for (int i = hex.Length - 1; i >= 0 ; i--)
            {
                Console.Write(hex[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

