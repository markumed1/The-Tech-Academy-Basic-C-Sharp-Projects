using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>(); //Referring to the property of a class.
            //List string and new empty list 
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven",
                "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            //foreach loop. nested for loop through both of this list in order to
            //generate 52 cards.
            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //during each loop we create a card
                    card.Suit = suit; // then we assign suit property, value = suit
                    card.Face = face; // same as line 29
                    Cards.Add(card); 
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
