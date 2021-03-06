﻿/*Write a program that generates and prints all possible cards from 
a standard deck of 52 cards (without the jokers). The cards should be 
printed using the classical notation (like 5 of spades, A of hearts, 
9 of clubs; and K of diamonds).
The card faces should start from 2 to A.
Print each card face in its four possible suits: clubs, diamonds, hearts and spades. 
Use 2 nested for-loops and a switch-case statement.*/
using System;

class PrintADeckOf52Cards
{
    static void Main()
    {
        string[] cards = { "Two", "Three", "Four", "Fifth", "Six", "Seven", "Eight",
            "Nine", "Ten", "Jack", "Queen", "King", "Ace" };
        string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };

        for (int i = 0;  i < suits.Length; i++)
        {
            for (int j = 0; j < cards.Length; j++)
            {
                Console.WriteLine("{0} of {1}", cards[j], suits[i]);
            }
            Console.WriteLine();
        }
    }
}

