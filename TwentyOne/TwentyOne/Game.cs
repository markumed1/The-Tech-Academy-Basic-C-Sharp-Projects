using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Game //<--Class
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers() //Doesn't return anything, just printing to the console.
        {
            foreach (string player in Players)
            {
                Console.WriteLine(Players);
            }
        }
    }
}
