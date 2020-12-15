using System;

namespace Snake.Models
{
    public class AppleTile : Tile
    {
        public AppleTile()
        {
            color = System.ConsoleColor.Red;
            symbol = '@';
        }
    }
}
