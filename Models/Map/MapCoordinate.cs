using System;

namespace Snake.Models
{
    public class MapCoordinate
    {
        public int X { get; }
        public int Y { get; }

        public MapCoordinate(Random rng)
        {
            X = rng.Next(0, 20);
            Y = rng.Next(0, 10);
        }

        public MapCoordinate(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
