using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a deck (object) method has to be part of a class.
            Deck deck = new Deck();
            deck = Shuffle(deck); //calling the method Line 26

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count); //'Cards' is the property of 'deck' and 'Cards' of data type list 'card'
            Console.ReadLine();
        }
        //public = accesible everywhere; static = so we don't have to create an object program before calling this;
        //Deck = type of data that is returning; Shuffle = name of the function.
        public static Deck Shuffle(Deck deck)
        {
            //creating a temp list
            List<Card> TempList = new List<Card>();
            Random random = new Random();

            //Create a while loop
            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);
                TempList.Add(deck.Cards[randomIndex]);
                deck.Cards.RemoveAt(randomIndex);
            }
            deck.Cards = TempList;
            return deck;

        }
    }
}
