using System;
using Snake.Models;
using Snake.Constants;
using System.Threading;

namespace Snake.Models
{
    public class Game
    {
        private Map map;
        private SnakeBody snake;
        private int refreshRate;

        public Game()
        {
            map = new Map();
            snake = new SnakeBody(map);
            refreshRate = 500;
        }

        public void Start()
        {
            map.Draw();
            Thread.Sleep(refreshRate);
            snake.Move();
            map.Draw();
            snake.CurrentDirection = Direction.Left;
            Thread.Sleep(refreshRate);
            snake.Move();
            map.Draw();
            Thread.Sleep(refreshRate);
            snake.Move();
            map.Draw();
            Thread.Sleep(refreshRate);
            snake.CurrentDirection = Direction.Down;
            snake.Move();
            map.Draw();
            Thread.Sleep(refreshRate);
            snake.Move();
            map.Draw();
            Thread.Sleep(refreshRate);
            snake.Move();
            map.Draw();
            Thread.Sleep(refreshRate);
            snake.Move();
            map.Draw();
            Thread.Sleep(refreshRate);
            snake.Move();
            map.Draw();
        }
    }
}
