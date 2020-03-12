using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDestiny
{
    public class GameEngine : fmGameMenu
    {
        public GameEngine(Action initializeComponent)
        {
            Console.WriteLine("Game Engine hooked...");
        }

        private void Start()
        {
            Console.WriteLine("Game Engine hooked...");
        }
           
    }
}
