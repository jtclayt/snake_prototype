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
            int r = 150;
            Map m = new Map();
            SnakeBody s = new SnakeBody(m);
            m.Draw();
            Thread.Sleep(r);
            s.Move();
            m.GenerateApple();
            m.Draw();
            s.CurrentDirection = Direction.Left;
            Thread.Sleep(r);
            s.Move();
            m.Draw();
            Thread.Sleep(r);
            s.Move();
            m.Draw();
            Thread.Sleep(r);
            s.CurrentDirection = Direction.Down;
            s.Move();
            m.Draw();
            Thread.Sleep(r);
            s.Move();
            m.Draw();
            Thread.Sleep(r);
            s.Move();
            m.Draw();
            Thread.Sleep(r);
            s.Move();
            m.Draw();
            Thread.Sleep(r);
            s.Move();
            m.Draw();
        }
    }
}
