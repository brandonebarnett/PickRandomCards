﻿using System;

namespace PickRandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of cards to pick: ");

            string line = Console.ReadLine();

            if(int.TryParse(line, out int numberOfCards))
            {
                string[] cards = CardPicker.PickSomeCards(numberOfCards);

                foreach (string card in cards)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("The number entered was not valid.");
            }
        }
    }
}
