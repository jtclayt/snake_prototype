using System;

namespace Snake.Models
{
    public class Map
    {
        private Tile[][] map;
        private Random rng;

        public Map()
        {
            rng = new Random();
            initializeMap();
        }

        private void initializeMap()
        {
            map = new Tile[10][];

            for (int i = 0; i < 10; i++)
            {
                map[i] = new Tile[20];
                for (int j = 0; j < 20; j++)
                {
                    map[i][j] = new BlankTile();
                }
            }
        }

        public void Draw()
        {
            Console.Clear();
            Console.WriteLine("----------------------");
            foreach (var row in map)
            {
                Console.Write('|');
                foreach(Tile tile in row)
                {
                    tile.Draw();
                }
                Console.WriteLine('|');
            }
            Console.WriteLine("----------------------");
        }

        public Tile GetTile(MapCoordinate coord)
        {
            return map[coord.Y][coord.X];
        }

        public void ChangeTile(MapCoordinate coord, Tile newTile)
        {
            map[coord.Y][coord.X] = newTile;
        }

        public void GenerateApple()
        {
            MapCoordinate randomCoord = new MapCoordinate(rng);

            while (GetTile(randomCoord) is not BlankTile)
            {
                randomCoord = new MapCoordinate(rng);
            }

            ChangeTile(randomCoord, new AppleTile());
        }
    }
}
