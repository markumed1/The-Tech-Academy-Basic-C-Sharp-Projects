using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //Constructor method name. Default values. (a methof called as soon as an object is create.
        public Card()
        {
            Suit = "Spades";
            Face = "Two";

        }
        //a class with two properties.
        public string Suit { get; set; }
        public string Face { get; set; }
    }   
}
