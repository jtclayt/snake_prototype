using System;
using Snake.Models;
using Snake.Constants;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Game myGame = new Game();
            myGame.Start();
        }
    }
}
