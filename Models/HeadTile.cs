using System;

namespace Snake.Models
{
    public class HeadTile : Tile
    {
        public HeadTile()
        {
            color = System.ConsoleColor.Green;
            symbol = '0';
        }
    }
}
