using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDestiny.Resources
{
    class Player : fmGameWindow
    {
        public void Start()
        {

            _createPlayer();
        }
        public void _createPlayer()
        {
            string user = "Player";
            int faction = 1;
            int level = 5;
            int health = 30;
            int basedamage = 5;
            Console.WriteLine("Player Created Successfully!");
           

        }
    }
}
