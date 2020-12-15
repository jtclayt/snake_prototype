using System;
using System.Collections.Generic;
using Snake.Constants;

namespace Snake.Models
{
    public class SnakeBody
    {
        private Map map;
        private LinkedList<MapCoordinate> snake;
        public Direction CurrentDirection { get; set; }

        public SnakeBody(Map gameMap)
        {
            snake = new LinkedList<MapCoordinate>();
            map = gameMap;
            CurrentDirection = Direction.Up;
            addHead(new MapCoordinate(7, 4));
            addBody(new MapCoordinate(8, 4));
            addBody(new MapCoordinate(9, 4));
            addBody(new MapCoordinate(9, 5));
        }

        private void addHead(MapCoordinate coord)
        {
            snake.AddFirst(coord);
            map.ChangeTile(coord, new HeadTile());
        }

        private void addBody(MapCoordinate coord)
        {
            snake.AddLast(coord);
            map.ChangeTile(coord, new BodyTile());
        }

        public void Move()
        {
            MapCoordinate newHead;
            MapCoordinate currentHead = snake.First.Value;
            MapCoordinate tail = snake.Last.Value;
            switch(CurrentDirection)
            {
                case Direction.Left:
                    newHead = new MapCoordinate(currentHead.X - 1, currentHead.Y);
                    break;
                case Direction.Right:
                    newHead = new MapCoordinate(currentHead.X + 1, currentHead.Y);
                    break;
                case Direction.Up:
                    newHead = new MapCoordinate(currentHead.X, currentHead.Y - 1);
                    break;
                default:
                    newHead = new MapCoordinate(currentHead.X, currentHead.Y + 1);
                    break;
            }
            map.ChangeTile(currentHead, new BodyTile());
            addHead(newHead);
            map.ChangeTile(tail, new BlankTile());
            snake.RemoveLast();
        }
    }
}
