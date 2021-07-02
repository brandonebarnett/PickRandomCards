using System;
using System.Collections.Generic;
using System.Text;

namespace PickRandomCards
{
    class CardPicker
    {
        // Static field called "random" used to generate random numbers
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for(int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // Get a random number from 1 to 4
            int value = random.Next(1, 5);

            // If it's 1, return the string Spades
            if (value == 1) return "Spades";

            // If it's 2, return Hearts
            if (value == 2) return "Hearts";

            // If it's 3, return Clubs
            if (value == 3) return "Clubs";

            // If we haven't returned yet, return the string Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            // Get a random number from 1 to 13
            int value = random.Next(1, 14);

            // If it's 1, return Ace
            if (value == 1) return "Ace";

            if (value == 2) return "Two";

            if (value == 3) return "Three";

            if (value == 4) return "Four";

            if (value == 5) return "Five";

            if (value == 6) return "Six";

            if (value == 7) return "Seven";

            if (value == 8) return "Eight";

            if (value == 9) return "Nine";

            if (value == 10) return "Ten";

            if (value == 11) return "Jack";

            if (value == 12) return "Queen";

            if (value == 13) return "King";

            return value.ToString();
        }
    }
}
