using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public abstract class Game //<--Class
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //every single class inherited had a method called "play".

        //Doesn't return anything, just printing to the console.//
        //virtaul method inside abstract class. Means that this method gets inherited, has the ability to override.
        public virtual void ListPlayers() 
        {
            foreach (Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }
    }
}
