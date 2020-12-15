using System;

namespace Snake.Models
{
    public class BlankTile : Tile
    {
        public BlankTile()
        {
            color = ConsoleColor.Black;
            symbol = ' ';
        }
    }
}
