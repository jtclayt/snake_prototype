using System;

namespace Snake.Models
{
    public abstract class Tile
    {
        protected ConsoleColor color;
        public ConsoleColor Color {
            get { return color; }
        }
        protected char symbol;
        public char Symbol {
            get { return symbol; }
        }

        public void Draw()
        {
            var originalColor = Console.ForegroundColor;
            Console.ForegroundColor = Color;
            Console.Write(Symbol);
            Console.ForegroundColor = originalColor;
        }
    }
}