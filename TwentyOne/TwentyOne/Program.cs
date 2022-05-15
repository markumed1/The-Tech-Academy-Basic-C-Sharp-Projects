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
            //create an object (deck) method has to be part of a class.
            Deck deck = new Deck();
            deck.Shuffle(3); //<--call this method shuffle

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);//'Cards' is the property of 'deck' and 'Cards' of data type list 'card'
            Console.ReadLine();
        }
        //public = accesible everywhere; static = so we don't have to create an object program before calling this;
        //Deck = type of data that is returning; Shuffle = name of the function.
 

        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
