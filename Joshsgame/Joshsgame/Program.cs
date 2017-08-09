using Game;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Joshgame
{
    class Program
    {
        static void Main(string[] args)
        {
            WordGame game = new WordGame();
            game.Introduction();
            game.PlayGame();
        }
    }
}