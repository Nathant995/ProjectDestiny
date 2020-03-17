using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDestiny.Resources;

namespace ProjectDestiny
{
    public class GameEngine : fmGameWindow
    {
        public Boolean _isDebug = false;
        public string _hostIP = "127.0.0.1";
        public string _serverIP = "localhost";
            
        public GameEngine(Action initializeComponent)
        {
            if (_isDebug == true)
            {
                Console.WriteLine("Game Engine is starting with Debugging options...");
            }

            Start();

        }

        private void Start()
        {
            Console.WriteLine("Game Engine hooked...");
            fmGameWindow game = new fmGameWindow();
            Console.WriteLine("Loading Game, Please Wait...");
            game.Show();

        }
           public void LoadGame()
        {
            Player p = new Player();
            p._createPlayer();
            
        }
    }
}
