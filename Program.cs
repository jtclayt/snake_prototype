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
            Map m = new Map();
            SnakeBody s = new SnakeBody(m);
            m.Draw();
            Thread.Sleep(1000);
            s.Move();
            m.GenerateApple();
            m.Draw();
            s.CurrentDirection = Direction.Left;
            Thread.Sleep(1000);
            s.Move();
            m.Draw();
            Thread.Sleep(1000);
            s.Move();
            m.Draw();
        }
    }
}
