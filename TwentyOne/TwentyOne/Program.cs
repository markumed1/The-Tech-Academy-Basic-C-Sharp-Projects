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
            //Polymorphism = Greek word that means to "have many forms"
            //               Objects can be identified by more than one type
            //               Ex. A Dog is also: Canine, Animal, Organism.

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Mark", "Miles", "Keven" };
            game.ListPlayers();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
