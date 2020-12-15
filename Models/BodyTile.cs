using System;

namespace Snake.Models
{
    public class BodyTile : Tile
    {
        public BodyTile()
        {
            color = System.ConsoleColor.White;
            symbol = 'O';
        }
    }
}
