/*Write a program that enters in integer n 
and prints the numbers 1, 2, …, n in random order.
Examples:
n	    randomized numbers 1…n
3	    2 1 3
10	    3 4 8 2 6 7 9 1 10 5
Note: The above output is just an example. Due to randomness, 
your program most probably will produce different results. 
You might need to use arrays.*/
using System;
using System.Linq;

class RandomizeNumbers1ToN
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] nums = new int[n];

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = i + 1;
        }
        Random rand = new Random();
        int[] randomArray = nums.OrderBy(x => rand.Next()).ToArray();
        foreach (var i in randomArray)
        {
            Console.Write("{0}", i);
        }
    }
}

